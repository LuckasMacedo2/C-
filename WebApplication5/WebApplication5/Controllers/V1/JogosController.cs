using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogoJogosAPI.InputModel;
using CatalogoJogosAPI.ViewModel;
using CatalogoJogosAPI.Services;
using System.ComponentModel.DataAnnotations;
using CatalogoJogosAPI.Exceptions;

namespace CatalogoJogosAPI.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        // Injeção de dependência
        private readonly IJogoService _jogoService; // ReadOnly pois o asp net cuidará da instanciação

        public JogosController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }

        /// <summary>
        /// Buscar jogos de forma paginada
        /// </summary>
        /// <param name="pagina">Pagina a ser buscada</param>
        /// <param name="quantidade">Quantidade de paginas retornada</param>
        /// <response code="200">Retorna a lista de jogos</response>
        /// <response code="204">Caso não haja jogos</response>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JogoViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1, [FromQuery, Range(1, 50)] int quantidade = 5)
        {
            var jogos = await _jogoService.Obter(pagina, quantidade);    // await faz com que fique esperando toda a lista ser executada

            if (jogos.Count() == 0)
                return NoContent();
            
            return Ok(jogos);
        }

        /// <summary>
        /// Obtém o jogo a partir do id do jogo
        /// </summary>
        /// <param name="idJogo">id do jogo a ser pesquisado</param>
        /// <response code="200">Retorna o jogo pesquisado</response>
        /// <response code="204">Caso não haja o jogo pesquisado</response>
        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<JogoViewModel>> Obter([FromRoute] Guid idJogo)
        {
            var jogo = await _jogoService.Obter(idJogo);

            if (jogo == null)
                return NoContent();

            return Ok(jogo);
        }

        /// <summary>
        /// Inseri o jogo no banco de dados
        /// </summary>
        /// <param name="jogoInputModel">Objeto com os dados do jogo</param>
        /// <response code="200">Retorna o jogo inserido</response>
        /// <response code="422">O jogo a ser inserido já está presente no banco de dados</response>
        [HttpPost]
        public async Task<ActionResult<JogoViewModel>> Inserir([FromBody] JogoInputModel jogoInputModel)
        {
            try
            {
                var jogo = await _jogoService.Inserir(jogoInputModel);

                return Ok(jogo);
            }
            catch (JogoJaCadastradoException ex)
            {
                return UnprocessableEntity("Já existe um jogo cadastrado com este nome para esta produtora");
            }
            
        }

        /// <summary>
        /// Atualiza o objeto jogo completo
        /// </summary>
        /// <param name="idJogo">id do jogo que será atualizado</param>
        /// <param name="jogoInputModel">Objeto contendo os dados para a atualização</param>
        /// <response code="200">Jogo atualizado com sucesso</response>
        /// <response code="404">O jogo a ser inserido já está presente no banco de dados</response>
        [HttpPut("{idJogo:guid}")]
        public async Task<ActionResult> AtualizarJogo([FromRoute] Guid idJogo, [FromBody] JogoInputModel jogoInputModel)
        {
            try
            {
                await _jogoService.Atualizar(idJogo, jogoInputModel);

                return Ok();
            }
            catch(JogoNaoCadastradoException ex)
            {
                return NotFound("Jogo não encontrado");
            }
        }

        /// <summary>
        /// Atualiza apenas o preço do jogo
        /// </summary>
        /// <param name="idJogo">id do jogo a ser atualizado</param>
        /// <param name="preco">Novo preço do jogo</param>
        /// <response code="200">Jogo atualizado com sucesso</response>
        /// <response code="404">O jogo a ser inserido já está presente no banco de dados</response>
        [HttpPatch("{idJogo:guid}/preco/{preco:double}")]
        public async Task<ActionResult> AtualizarJogo([FromRoute] Guid idJogo, double preco)
        {
            try
            {
                await _jogoService.Atualizar(idJogo, preco);

                return Ok();
            }
            catch(JogoNaoCadastradoException ex)
            {
                return NotFound("Jogo não encontrado");
            }
        }

        /// <summary>
        /// Atualiza apenas o nome do jogo
        /// </summary>
        /// <param name="idJogo">id do jogo a ser alterado</param>
        /// <param name="nome">Novo nome do jogo</param>
        /// <response code="200">Jogo atualizado com sucesso</response>
        /// <response code="404">O jogo a ser inserido já está presente no banco de dados</response>
        [HttpPatch("{idJogo:guid}/nome/{nome:alpha}")]
        public async Task<ActionResult> AtualizarJogo([FromRoute] Guid idJogo, string nome)
        {
            try
            {
                await _jogoService.Atualizar(idJogo, nome);

                return Ok();
            }
            catch (JogoNaoCadastradoException ex)
            {
                return NotFound("Jogo não encontrado");
            }
        }

        /// <summary>
        /// Remove o jogo do banco de dados
        /// </summary>
        /// <param name="idJogo">id do jogo a ser removido</param>
        /// <response code="200">Exclusão realizada com sucesso</response>
        /// <response code="404">O jogo a ser inserido já está presente no banco de dados</response>
        [HttpDelete("{idJogo:guid}")]
        public async Task<ActionResult> ApagarJogo(Guid idJogo)
        {
            try
            {
                await _jogoService.Remover(idJogo);

                return Ok();
            }
            catch(JogoNaoCadastradoException ex)
            {
                return NotFound("Jogo não encontrado");
            }
        }
    }
}

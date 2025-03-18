using Microsoft.EntityFrameworkCore;
using WebApi8.Data;
using WebApi8.Dto.Livro;
using WebApi8.Models;

namespace WebApi8.Services.Livro
{
    public class LivroService : ILivroInterface
    {
        private readonly AppDbContext _context;

        public LivroService(AppDbContext context)
        {
            _context = context;
        }

        public Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<LivroModel>> BuscarLivroPorIdAutor(int idAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<LivroModel>> CirarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<LivroModel>>> EditarLivro(LivroEdicaoDto livroEdicaoDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idLivro)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<LivroModel>>> ListarLivros()
        {
            ResponseModel<List<LivroModel>> resposta = new ResponseModel<List<LivroModel>>();

            try
            {
                var livros = await _context.Livros
                    .Include(a => a.Autor)
                    .ToListAsync();
                resposta.Dados = livros;
                resposta.Mensagem = "Todos os livros foram encontrados com sucesso!";
                return resposta;
            } catch (Exception ex)
            {
                resposta.Mensagem = "Nenhum livro foi encontrado!";
                resposta.Status = false;
                return resposta;
            }
        }
    }
}

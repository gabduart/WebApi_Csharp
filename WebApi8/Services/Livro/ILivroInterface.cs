using WebApi8.Dto.Autor;
using WebApi8.Dto.Livro;
using WebApi8.Models;

namespace WebApi8.Services.Livro
{
    public interface ILivroInterface
    {
        // Get
        Task<ResponseModel<List<LivroModel>>> ListarLivros();
        Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro);
        Task<ResponseModel<List<LivroModel>>> BuscarLivroPorIdAutor(int idAutor);

        // Post
        Task<ResponseModel<LivroModel>> CirarLivro(LivroCriacaoDto livroCriacaoDto);

        // Put
        Task<ResponseModel<List<LivroModel>>> EditarLivro(LivroEdicaoDto livroEdicaoDto);

        // Delete
        Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idLivro);
    }
}

using Project5_DapperNorthwind.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        //tüm kategori verilerini dönen bir Task (asenkron çalışma) işlevidir. Asenkron olarak çalışır ve sonucu liste şeklinde geri döner
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        //Yeni bir kategori oluşturmak için kullanılır. Parametre olarak bir CreateCategoryDto alır ve dönüş tipi Task'tır. Bu da metodun asenkron çalıştığını ve bir sonuç döndürmediğini gösterir
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        //Var olan bir kategoriyi güncellemek için kullanılır. UpdateCategoryDto adında bir DTO nesnesini parametre olarak alır. Asenkron çalışır ve sonuç döndürmez.
        Task DeleteCategoryAsync(int id);
        //kategori silme işlemini gerçekleştirmek için kullanılır. Silinecek kategoriye ait id parametre olarak alınır ve asenkron olarak çalışır. Sonuç döndürmez.
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id);
    }   //Kategorinin id'sini alır ve bu id'ye karşılık gelen veriyi GetByIdCategoryDto nesnesi olarak geri döner.
}

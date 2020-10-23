/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：{Comment}                                                    
*│　作    者：{Author}                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：{GeneratorTime}                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： {IRepositoryNamespace}                                   
*│　接口名称： I{ModelName}Repository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Threading.Tasks;
using Samples.Models;
using YDal.Repository;
using YDal.UnitOfWork;

namespace Samples.Repository
{
    public interface IdemoRepository : IRepository<demo>
    {
         
    }
}
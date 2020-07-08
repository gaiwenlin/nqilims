using NQI_LIMS.Common;
using NQI_LIMS.Controllers;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using Moq;
using Xunit;
using System;
using Microsoft.Extensions.Logging;
using Autofac;

namespace NQI_LIMS.Tests
{
    public class BlogController_Should
    {
        Mock<IBlogArticleServices> mockBlogSev = new Mock<IBlogArticleServices>();
        Mock<IRedisCacheManager> mockRedisMag = new Mock<IRedisCacheManager>();
        Mock<ILogger<BlogController>> mockLogger = new Mock<ILogger<BlogController>>();
        BlogController blogController;

        private IBlogArticleServices blogArticleServices;
        DI_Test dI_Test = new DI_Test();



        public BlogController_Should()
        {
            mockBlogSev.Setup(r => r.Query());


            var container = dI_Test.DICollections();
            blogArticleServices = container.Resolve<IBlogArticleServices>();
            blogController = new BlogController(blogArticleServices, mockLogger.Object);
        }

        [Fact]
        public void TestEntity()
        {
            BlogArticle blogArticle = new BlogArticle();

            Assert.True(blogArticle.bID >= 0);
        }
        [Fact]
        public async void GetBlogsTest()
        {
            object blogs =await blogController.Get(1);

            Assert.NotNull(blogs);
        }

        [Fact]
        public async void PostTest()
        {
            BlogArticle blogArticle = new BlogArticle()
            {
                bCreateTime = DateTime.Now,
                bUpdateTime = DateTime.Now,
                btitle = "xuint :test controller addEntity",

            };

            var res = await blogController.Post(blogArticle);

            Assert.True(res.success);

            var data = res.response;

            Assert.NotNull(data);
        }
    }
}

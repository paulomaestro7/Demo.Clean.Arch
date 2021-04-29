using Demo.Clean.Arch.Model;
using Demo.Clean.Arch.Repository.Interface;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Demo.Clean.Arch.Repository.Test
{
    public class Tests
    {
        private static IServiceProvider _serviceProvider;
        private static IUserLevelRepository _userLevelRepository;

        [SetUp]
        public void Setup()
        {
            new StartFactory().Start(ref _serviceProvider);
            _userLevelRepository = (IUserLevelRepository)_serviceProvider.GetService(typeof(IUserLevelRepository));
        }

        [Test]
        public async Task Add_User_Level_Ok()
        {
            var result = await _userLevelRepository.SaveUserLevel(new UserLevelModel()
            {
                Name = "Paulo Maestro",
                Active = false
            });
            Assert.True(result);
        }
    }
}
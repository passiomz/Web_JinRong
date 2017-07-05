using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp;
using WebApp.Controllers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using WebApp.Dependency;
using NUnit.Framework;
using Castle.MicroKernel.Registration;
using WebApp.Service;

namespace WebApp.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        WindsorContainer _windsorContainer;
        [SetUp]
        public void Init()
        {
            _windsorContainer = new WindsorContainer();
            _windsorContainer.Install(FromAssembly.Containing<WebApp.Dependency.WebAppDependencyInstaller>());
            _windsorContainer.Install(FromAssembly.This());
            ControllerInstaller _controlInstaller = new ControllerInstaller();
            _controlInstaller.Install(_windsorContainer);
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_windsorContainer.Kernel));
        }

         [Test]
        public void Index()
        {
            var homeController = _windsorContainer.Resolve<HomeController>();
            homeController.Index();
        }
    }
}

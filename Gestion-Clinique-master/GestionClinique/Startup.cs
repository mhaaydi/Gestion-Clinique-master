using GestionClinique.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionClinique.Startup))]
namespace GestionClinique
{
    public partial class Startup
    {
        
        ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRoles();
            CreateUsers();
        }
        public void CreateUsers()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = new ApplicationUser();
            user.Email = "mariammoussa.mk@gmail.com";
            user.UserName = "Mkonate";
            var check = userManager.Create(user,"Mkonate10");
            if (check.Succeeded)
            {
                userManager.AddToRole(user.Id,"Admin");
            }
        }
        public void CreateRoles()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            IdentityRole role = new IdentityRole();
            if (!roleManager.RoleExists("Responsable"))
            {
                role = new IdentityRole();
                role.Name = "Responsable";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Admin"))
            {
                role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Medecin"))
            {
                role = new IdentityRole();
                role.Name = "Medecin";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Patient"))
            {
                role = new IdentityRole();
                role.Name = "Patient";
                roleManager.Create(role);
            }
        }
    }
}

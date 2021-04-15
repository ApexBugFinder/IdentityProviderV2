//using IdentityServer4.Models;

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.IdentityModel;
//namespace WebApplication2
//{
//    public class Config
//    {

//        // List of Identity Resources that help define each user
//        public static IEnumerable<IdentityResource> GetIdentityResources()
//        {
//            return new List<IdentityResource>
//            {
//                new IdentityResources.OpenId(),
//                new IdentityResources.Profile(),
//                new IdentityResources.Email(),
//                new IdentityResource("recipeantwebuiscope", new [] {"role", "admin", "user", "recipeant", "recipeant.admin", "recipeant.user"}),

//            };
//        }


//        // List of all Api Resources
//        public static IEnumerable<ApiResource> GetApiResources()
//        {
//            return new List<ApiResource>
//            {
//                new ApiResource("recipeantwebapi")
//                {
//                    ApiSecrets =
//                    {
//                        new Secret("recipeantWebApiSecret".Sha256())
//                    },
//                    Scopes =
//                    {
//                        new Scope
//                        {

//                            Name = "recipeantwebapi",
//                            DisplayName = "Scope for the recipeantwebapi Api Resource",


//                        }
//                    },
//                    UserClaims =
//                    {
//                        "role", "admin", "user", "recipeantwebapi", "recipeantwebapi.admin", "recipeantwebapi.user"
//                    }
//                }
//            };
//        }


//        public static IEnumerable<Client> GetClients()
//        {
//            return new List<Client>
//            {
//                new Client
//                {
//                    ClientName = "recipeantwebUi",
//                    ClientId = "recipeantwebUi",
//                    AccessTokenType = AccessTokenType.Jwt,
//                    AccessTokenLifetime = 3300, // 3300 seconds, default 60 mins which is 3600s
//                    IdentityTokenLifetime = 3000,


//                    RequireClientSecret = false,
//                    AllowedGrantTypes = GrantTypes.Code,
//                    RequirePkce = true,

//                    AllowAccessTokensViaBrowser = true,
//                    AllowOfflineAccess = true,
//                    AlwaysIncludeUserClaimsInIdToken = true,
//                    RedirectUris = new List<string>
//                    {

//                    },
//                    PostLogoutRedirectUris = new List<string>
//                    {

//                    },
//                    AllowedCorsOrigins = new List<string>
//                    {

//                    },
//                    AllowedScopes = new List<string>
//                    {
//                        "openid",
//                        "recipeantwebapi",
//                        "recipeantwebapuiscope",
//                        "role",
//                        "profile",
//                        "email"
//                    }


//                }
//            };
//        }
//    }
//}

using IdentityServer4.Models;
using System.Collections.Generic;

namespace WebApplication2
{
    public class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResources.Address(),
                new IdentityResource("country", "the country you're living in", new List<string>() {"country"}),
                new IdentityResource("username", "What handle you go by", new List<string>() {"username"}),

         //       new IdentityResource("dataeventrecordsir",new []{ "role", "admin", "user", "dataEventRecords", "dataEventRecords.admin" , "dataEventRecords.user" } ),
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("dataEventRecords", "Scope for the dataEventRecords ApiResource",
                    new List<string> { "role", "admin", "user", "dataEventRecords", "dataEventRecords.admin", "dataEventRecords.user"}),
                new ApiScope("recipeantwebapi", "Scope for the RecipeAnt Web ApI",
                    new List<string> { "role"})

            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("dataEventRecordsApi")
                {
                    ApiSecrets =
                    {
                        new Secret("dataEventRecordsSecret".Sha256())
                    },
                    Scopes = new List<string> { "dataEventRecords" }
                },
                new ApiResource(
                    "recipeantwebapi",
                    "RecipeAnt Web API",
                    new List<string>() {"role"})
                {
                    ApiSecrets = { new Secret("apisecret".Sha256())}
                }
            };
        }

        // clients want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients()
        {
            // client credentials client
            return new List<Client>
            {
                new Client
                {
                    ClientName = "RecipeAnt Client",
                    ClientId = "recipeant2019",
                    ClientUri = "http://localhost:4200",
                    AccessTokenType = AccessTokenType.Jwt,
                    AccessTokenLifetime = 3300,// 330 seconds, default 60 minutes
                    IdentityTokenLifetime = 3000,

                    RequireClientSecret = false,
                    AllowedGrantTypes = GrantTypes.Implicit,
                    

                    AllowAccessTokensViaBrowser = true,
                    AllowOfflineAccess =true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:4200",
                        "http://localhost:4200/silent-renew.html",
                        "http://localhost:4200/auth/auth-callback",
                        "https://localhost:44314",
                        "https://localhost:44353"


                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "https://localhost:4200/unauthorized",
                        "https://localhost:4200"
                    },
                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:4200",
                        "https://localhost:44353",
                        "https://localhost:"
                    },
                    AllowedScopes = new List<string>
                    {
                        "openid",
                        "role",
                        "profile",
                        "email",
                        "recipeantwebapi"
                    }
                }
                //new Client
                //{
                //    ClientName = "angularclient2",
                //    ClientId = "angularclient2",
                //    AccessTokenType = AccessTokenType.Jwt,
                //    AccessTokenLifetime = 3300,// 330 seconds, default 60 minutes
                //    IdentityTokenLifetime = 3000,

                //    RequireClientSecret = false,
                //    AllowedGrantTypes = GrantTypes.Code,
                //    RequirePkce = true,

                //    AllowAccessTokensViaBrowser = true,
                //    AllowOfflineAccess =true,
                //    AlwaysIncludeUserClaimsInIdToken = true,
                //    RedirectUris = new List<string>
                //    {
                //        "https://localhost:44395",
                //        "https://localhost:44395/silent-renew.html"
                //    },
                //    PostLogoutRedirectUris = new List<string>
                //    {
                //        "https://localhost:44395/unauthorized",
                //        "https://localhost:44395"
                //    },
                //    AllowedCorsOrigins = new List<string>
                //    {
                //        "https://localhost:44395"
                //    },
                //    AllowedScopes = new List<string>
                //    {
                //        "openid",
                //        "dataEventRecords",
                //        "dataeventrecordsscope",
                //        "role",
                //        "profile",
                //        "email"
                //    }
                //}
            };
        }
    }
}

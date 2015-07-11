var honey = angular.module('poissonnerie', ['MainController', 'ngRoute']);

honey.config(["$routeProvider",
        function($routeProvider){
            
            //Acueil            
            $routeProvider.when("/home", {
                templateUrl : "views/home.html",
                controller: "HomeController"
                })
            
            //Comptes Clients           
            .when("/page1", {
                templateUrl: "views/page1.html",
                controller: "ContenuController"               
            })

            //Badges
            .when("/badges/:numAbonnement", {
                templateUrl: "views/Badges/badges.html",
                controller: "ContenuController"               
            })

            //Administration
            .when("/administration", {
                templateUrl: "views/Administration/administration.html",
                controller: "ContenuController"
            })

            //Login
            .when("/login", {
                templateUrl: "views/login.html",
                controller: "LoginController"
            })

            .otherwise({
                redirectTo:"/home"
            })
        }]);



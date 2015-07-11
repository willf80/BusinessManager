var MainController = angular.module('MainController', []);

//Controleur du GlobalController
MainController.controller('GlobalController', ['$rootScope', '$scope', '$http',
function ($rootScope, $scope, $http) {

    $rootScope.user = {};
    $rootScope.showSidebar = true;
    //$rootScope.login = null;

    console.log($rootScope.user);

}]);

//Controleur du contenu Principal
MainController.controller('HomeController', ['$rootScope', '$scope', '$http',
function ($rootScope, $scope, $http) {

    console.log("Home result : ");
    console.log($rootScope.user);

    $http.get("../handlers/Test.ashx")
    .success(function (data) {
        console.log(data);
    })
    .error(function (data) { $("#loading").fadeOut("fast"); });

}]);

//Controleur d'authentification
MainController.controller('LoginController', ['$rootScope', '$scope', '$http',
function ($rootScope, $scope, $http) {
    
    $rootScope.showSidebar = false;
    $scope.connexion = { modeavance: false };

    //console.log("Controleur d'authentification");
    $scope.connecter = function () {

        $rootScope.user = $scope.connexion;
        console.log($rootScope.user);

        window.location = '#/home';
        $rootScope.showSidebar = true;

        //var fd = { login: 'anicet', password: 'anicet' };
        //$("#loading").fadeIn("slow");
        //$http.get("Handlers/ConnexionHandler.ashx")
        //.success(function (data) {
        //    if (data["succes"]) {
        //        $("#loading").fadeOut("fast");
        //        //alert("Welcome !");
        //        if (data["Config"]["IsConfig"])
        //            document.location = "index.html#/home";
        //        else
        //            window.location = "startconfig.html";
        //    } else {
        //        $("#loading").fadeOut("fast");
        //        $("#login-form").hide();

        //        $("#error-login").css("display", "table");
        //        $("#error-login").html('<i class="glyphicon glyphicon-remove-circle"></i> ' + data['message']);
        //    }
        //})
        //.error(function (data) { $("#loading").fadeOut("fast"); });
    }
    //$scope.connecter();
}]);

//Controleur de la page Comptes Clients
MainController.controller('CompteClientController', ['$rootScope', '$scope', '$http',
function ($rootScope, $scope, $http) {

}]);

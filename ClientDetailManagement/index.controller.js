(function () {
    'use strict';

    function indexController($location, $scope, userService) {
        /* jshint validthis:true */
        var vm = this;
        $scope.user = {};
        vm.title = 'index';
        $scope.isSaving = false;
        $scope.isUpdate = false;
        $scope.isSave = false;
        $scope.isLoading = true;
        init();

        function init() {
            userService.getUserToUpdate().then(function (user) {
                $scope.isLoading = false;
                if (user.FirstName != null) {
                    $scope.isUpdate = true;
                    $scope.user = user;
                } else {
                    $scope.isSave = true;
                }
            })
        }

        $scope.saveUser = function (user) {
            $scope.user = {};
            $scope.isSaving = true;
            userService.saveUser(user).then(function (result) {
                $scope.isSaving = false;
                if (result) {
                    alert('user was saved');
                } else {
                    alert("user was not saved");
                }
            })
        }

        $scope.updateUser = function (user) {
            $scope.user = {};
            $scope.isSaving = true;
            userService.updateUser(user).then(function (result) {
                $scope.isSaving = false;
                if (result) {
                    alert('user was saved');
                } else {
                    alert("user was not saved");
                }
            })
        }


    }

    angular.module('CD').controller('indexController', indexController);
    indexController.$inject = ['$location', '$scope', 'userService'];
})();

(function () {
    'use strict';

    function userService($http, $q, baseUrl) {
        /* jshint validthis:true */

        this.getUserToUpdate = function () {
            var defered = $q.defer();


            var updateUserComplete = function (response) {
                defered.resolve(response.data);
            }

            $http.get(baseUrl + '/User/GetUsedToUpdate/').then(updateUserComplete, function (err, status) {
                defered.reject(err);
            });

            return defered.promise;
        }

        this.saveUser = function (user) {
            var defered = $q.defer();


            var saveUserComplete = function (response) {
                defered.resolve(response.data);
            }

            $http.post(baseUrl + '/User/SaveUser', user).then(saveUserComplete, function (err, status) {
                defered.reject(err);
            });

            return defered.promise;
        }

        this.updateUser = function (user) {
            var defered = $q.defer();


            var updateUserComplete = function (response) {
                defered.resolve(response.data);
            }

            $http.put(baseUrl + '/User/UpdateUser', user).then(updateUserComplete, function (err, status) {
                         defered.reject(err);
                     });

            return defered.promise;
        }

    }

    angular.module('CD').service('userService', userService);
    userService.$inject = ['$http', '$q', 'baseUrl'];
})();
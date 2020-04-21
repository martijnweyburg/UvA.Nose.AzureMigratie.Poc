var modelCreate = {
    LastName: ko.observable(),
    FirstMidName: ko.observable(),
    EnrollmentDate: ko.observable(),
    createStudent: function () {
        try {
            $.ajax({
                url: '/Students/Create',
                type: 'post',
                dataType: 'json',
                data: ko.toJSON(this),
                contentType: 'application/json',
                success: successCallback,
                error: errorCallback
            });
        } catch (e) {
            window.location.href = '/Students/';
        }
    }
};
function successCallback(data) {
    window.location.href = '/Students/';
}
function errorCallback(err) {
    window.location.href = '/Students/';
}


$(function () {
    ko.applyBindings(modelCreate);
});
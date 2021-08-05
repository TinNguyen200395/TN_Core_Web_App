var loginControler = function () {
    this.initialize = function () {
        registerEvents();
    }
    var registerEvents = function () {

        $('#btnLogin').on('click', function (e) {
            e.preventDefault();
            var user = $('#txtUserName').val();
            var password = $('#txtPassword').val();
            login(user, password);
        });
    }
    var login = function (user, pass) {
        // truyền vào một đối tượng 
        $.ajax({
            type: 'POST',
            data: {
                UserName: user,
                Password: pass
            },
            // tự truyền lên 
            dataType: 'json',
            // đẩy lên 
            url: '/admin/login/authen',
            // nếu mà thành công 
            success: function (res) {
                if (res.Success) {
                    window.location.href = "/Admin/Home/Index";

                }
                else {
                    tn.notify('Login unsuccessful!', 'error');
                }
            }

        })
    }
}
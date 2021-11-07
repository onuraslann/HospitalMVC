$(function () {
   
    $("#tblAppointment").on("click", ".btnAppointmentDelete", function () {
        var btn = $(this);
        bootbox.confirm("Appointmentı silmek istediğinize eminmisiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({

                    type: "GET",
                    url: "/Appointment/Delete/" + id,
                    success: function () {

                        btn.parent().parent().remove();
                    }


                });
            }

        });
    });

});
$(function () {

    $("#tblDepartman").on("click", ".btnDepartmanDelete", function () {
        var btn = $(this);
        bootbox.confirm("Departmanı silmek istediğinize eminmisiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({

                    type: "GET",
                    url: "/Departman/Delete/" + id,
                    success: function () {

                        btn.parent().parent().remove();
                    }


                });
            }

        });
    });

});
$(function () {

    $("#tblDoctor").on("click", ".btnDoctorDelete", function () {
        var btn = $(this);
        bootbox.confirm("Doctoru silmek istediğinize eminmisiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({

                    type: "GET",
                    url: "/Doctor/Delete/" + id,
                    success: function () {

                        btn.parent().parent().remove();
                    }


                });
            }

        });
    });

});
$(function () {

    $("#tblPrescription").on("click", ".btnPrescriptionDelete", function () {
        var btn = $(this);
        bootbox.confirm("Reçeteyi silmek istediğinize eminmisiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({

                    type: "GET",
                    url: "/Prescription/Delete/" + id,
                    success: function () {

                        btn.parent().parent().remove();
                    }


                });
            }

        });
    });

});
$(function () {

    $("#tblSick").on("click", ".btnSickDelete", function () {
        var btn = $(this);
        bootbox.confirm("Hastayı silmek istediğinize eminmisiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({

                    type: "GET",
                    url: "/Sick/Delete/" + id,
                    success: function () {

                        btn.parent().parent().remove();
                    }


                });
            }

        });
    });

});
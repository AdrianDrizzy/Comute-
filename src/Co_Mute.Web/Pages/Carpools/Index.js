$(function () {
    var l = abp.localization.getResource('Co_Mute');
    var createModal = new abp.ModalManager(abp.appPath + 'Carpools/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Carpools/EditModal');

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });
    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewCarpoolButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

    var dataTable = $('#CarpoolsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: true,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(co_Mute.carpools.carpool.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('Co_Mute.Carpools.Edit'), //CHECK for the PERMISSION
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('Co_Mute.Carpools.Delete'), //CHECK for the PERMISSION
                                    confirmMessage: function (data) {
                                        return l('CarpoolDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        co_Mute.carpools.carpool
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(l('SuccessfullyDeleted'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }

                            ]
                    }
                },
                {
                    title:l('DepartureTime'),
                    data: "departureTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title:l('ExpectedArrivalTime'), data: "expectedArrivalTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                },
               
                {
                    title: l('Origin'),
                    data: "origin"
                },
                {
                    title: l('DaysAvailable'),
                    data: "daysAvailable"
                },
                {
                    title: l('Destination'),
                    data: "destination"
                },
                {
                    title: l('AvailableSeats'),
                    data: "availableSeats"
                },
                {
                    title: l('OwnerLeader'),
                    data: "ownerLeader"
                },
                {
                    title: l('Notes'),
                    data: "notes"
                }
                
            ]
        })
    );
   

   

});

// Usa JQuery para alterar as legendas da tabela (DataTable)
$(document).ready(function () {
    const tabela = $('#emprestimo-tab').DataTable({
        language: {
            decimal: "",
            emptyTable: "Sem dados para essa tabela",
            info: "Mostrar _START_ ao _END_ de _TOTAL_ entradas",
            infoEmpty: "Mostrar 0 a 0 de 0 entradas",
            infoFiltered: "(Filtrado pelo total de entradas: _MAX_)",
            thousands: ",",
            lengthMenu: "Mostrar _MENU_ entradas",
            loadingRecords: "Carregando...",
            search: "Procurar:",
            zeroRecords: "Sem combinações encontradas",
            paginate: {
                first: "Primeiro",
                last: "Último",
                next: "Próximo",
                previous: "Anterior"
            },
        }
    });

    // Impede refresh ao apertar Enter no campo de busca
    $('#emprestimo-tab_filter input').on('keypress', function (e) {
        if (e.which === 13) e.preventDefault();
    });

    // Fecha o alerta depois de 5 segundos 
    setTimeout(function () {
        $('.alert').fadeOut("slow", function () {
            $(this).alert('close');
        });
    }, 3000);
});

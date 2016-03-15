function OnSuccess(response) {
    $.notify("Update Successful", { className:'success', globalPosition: "bottom center", showDuration: 300 });
}

function OnFailure(response) {
    $.notify("Update Failure", { className: 'error', globalPosition: "bottom center", showDuration: 300 });
}

function OnBegin(response) {
}

function OnComplete(response) {
}
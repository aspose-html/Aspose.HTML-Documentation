const uploadUrl = 'https://localhost:5001/files';
const convertUrl = 'https://localhost:5001/conversion';

function run(){

    showLoader();
    const data = document.querySelector('[name=fileupload]').files[0];

    const xrs = new XMLHttpRequest();
    let e = document.getElementById("selectOutputFormat");
    let outputFormat = e.options[e.selectedIndex].text;
    let inputFormat = document.getElementById("inputFormat").value;

    xrs.onload = () => {
        if(xrs.status == 200){
            let params = JSON.stringify({
                'Files': JSON.parse(xrs.response),
                'InputFormat': inputFormat,
                'OutputFormat': outputFormat
            });
            convert(params);
        } else {
            processError("Conversion faulted");
        }
    };

    let formData = new FormData();
    formData.append("file", data);
    xrs.open("POST", uploadUrl);
    xrs.send(formData);
}


function convert(params){
    const xrs = new XMLHttpRequest();
    xrs.open("POST", convertUrl);
    xrs.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xrs.send(params);

    xrs.onload = () => {
        if(xrs.status == 200){
            let res = JSON.parse(xrs.response);
            let id = res.id;
            switch (res.status) {
                case "running":
                case "pending":
                    setTimeout(function () {
                        checkStatus(id);
                    }, 3000);
                    break;
                case 'completed':
                    downloadResult(res.file.hRef);
                    break;
                default:
                    ProcessError("Conversion faulted");
            }
        } else {
            ProcessError("Conversion faulted");
        }
    };
}

function checkStatus(id) {
    const xrs = new XMLHttpRequest();
    xrs.open("GET", convertUrl + "?id=" + id);
    xrs.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xrs.send();

    xrs.onload = () => {
        if (xrs.status == 200) {
            let res = JSON.parse(xrs.response);
            switch (res.status) {
                case "running":
                case "pending":
                    setTimeout(function () {
                        checkStatus(id);
                    }, 3000);
                    break;
                case 'completed':
                    downloadResult(res.file.hRef);
                    break;
                default:
                    processError("Conversion faulted");
            }
        } else {
            processError("Error");
        }
    }
}

function downloadResult(f){
    let link = document.createElement("a");
    let name = 'output.pdf';
    link.setAttribute('download', name);
    link.href = uploadUrl + '?uri=' + f;
    document.body.appendChild(link);
    link.click();
    link.remove();
    hideLoader();
}

function processError(err){
    console.log(err);
    hideLoader();
}

function showLoader(){
    document.body.style.cursor = 'wait';
}

function hideLoader(){
    document.body.style.cursor = 'auto';
}
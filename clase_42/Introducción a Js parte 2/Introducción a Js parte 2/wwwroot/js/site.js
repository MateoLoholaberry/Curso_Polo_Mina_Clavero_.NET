let listArticulos = [];

async function getAll() {
   await fetch('https://jsonplaceholder.typicode.com/posts')
        .then((response) => response.json())
        .then((items) => {

            console.log(items)
            listArticulos = listArticulos.concat(items)

            populateTable();


        });
}


async function create() {

    let userId = document.getElementById("userIdInput").value;
    let title = document.getElementById("titleInput").value;
    let body = document.getElementById("bodyInput").value;


   await fetch('https://jsonplaceholder.typicode.com/posts', {
        method: 'POST',
        body: JSON.stringify({
            title: title,
            body: body,
            userId: userId,
        }),
        headers: {
            'Content-type': 'application/json; charset=UTF-8',
        },
   })
        .then((response) => response.json())
        .then((response) => {
            console.log(response);
            listArticulos.push(response);

            populateTable();
        });
}




function populateTable() {
    const tableBody = document.getElementById("testBody");
    tableBody.innerHTML = "";

    listArticulos.forEach(item => {
        let row = tableBody.insertRow();
        let id = row.insertCell(0);
        id.innerHTML = item.id;

        let userid = row.insertCell(1);
        userid.innerHTML = item.userId;

        let title = row.insertCell(2);
        title.innerHTML = item.title;

        let body = row.insertCell(3);
        body.innerHTML = item.body;
    })
}
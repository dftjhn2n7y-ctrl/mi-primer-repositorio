console.log ("hola mundo desde node");
const http = require ('http');

const server = http.createServer((req, res) => {
    res.write('Servidor funcionando');
    res.end();
});

server.listen(3000);

console.log('Servidor en puerto 3000');
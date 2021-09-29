const express = require('express')
const app = express()
const port = 3000

let books = [];

app.use(express.json());
app.use(express.urlencoded({extended: false})); //Parse URL-encoded bodies

app.post('/books', (req, res) => {
    const book = req.body;
    books.push(book);

    res.send ('book has been added to the database');
    console.log(`book name is ${book.name} number of book is ${books.length}`);

});

app.get('/books', (req, res) => {
  res.json(books);
})



app.get('/', (req, res) => res.send('Hello World from Una!'))

app.listen(port, () => console.log(`Example app listening on port ${port}!`))

app.get('/bananas', (req, res) =>
  res.send('hello world, this is bananas'));


app.get('/silly', (req, res) =>
  res.send('this is a silly one'));


  app.use(express.json());
  app.use(express.urlencoded({extended: false})); //Parse URL-encoded bodies
  


import React from 'react';

function BookDetails(props) {
  const bookList = (
    <ul>
      {props.books.map((book) => (
        <div key={book.id}>
          <h3>{book.bname}</h3>
          <h4>₹ {book.price}</h4>
        </div>
      ))}
    </ul>
  );

  return <div>{bookList}</div>;
}

export default BookDetails;

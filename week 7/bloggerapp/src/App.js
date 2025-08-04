import React from 'react';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';
import { books, blogs, showCourses } from './data';

function App() {
  return (
    <div style={{ padding: '20px' }}>
      <div className="st2">
        <h1>Book Details</h1>
        <BookDetails books={books} />
      </div>

      <div className="v1">
        <h1>Blog Details</h1>
        <BlogDetails blogs={blogs} />
      </div>

      <div className="mystyle1">
        <h1>Course Details</h1>
        <CourseDetails showCourses={showCourses} />
      </div>
    </div>
  );
}

export default App;

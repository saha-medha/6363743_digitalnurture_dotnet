import React from 'react';

function CourseDetails({ showCourses }) {
  const courses = ['React', 'Angular', 'Node.js'];

  if (!showCourses) {
    return <p>Courses are currently unavailable.</p>;
  }

  return (
    <div>
      {courses.length > 0 &&
        courses.map((course, idx) => <li key={idx}>{course}</li>)}
    </div>
  );
}

export default CourseDetails;

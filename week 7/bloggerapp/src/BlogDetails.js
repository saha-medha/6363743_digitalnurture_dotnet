import React from 'react';

function BlogDetails({ blogs }) {
  return (
    <div>
      {blogs.length > 0 ? (
        blogs.map((blog) => (
          <div key={blog.id}>
            <h3>{blog.title}</h3>
            <p>By {blog.author}</p>
          </div>
        ))
      ) : (
        <p>No blogs to show.</p>
      )}
    </div>
  );
}

export default BlogDetails;

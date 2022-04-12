import React from 'react';
import PostForm from './PostForm';
import { useParams, useNavigate } from 'react-router-dom';


const EditPost = ({ posts, setPosts }) => {
  let navigate = useNavigate();
  const { id } = useParams();
  const postToEdit = posts.find((post) => post.id === id);

  const handleOnSubmit = (post) => {
    const filteredPost = posts.filter((post) => post.id !== id);
    setPosts([post, ...filteredPost]);
    navigate('/');
  };

  return (
    <div>
      <PostForm post={postToEdit} handleOnSubmit={handleOnSubmit} />
    </div>
  );
};

export default EditPost;
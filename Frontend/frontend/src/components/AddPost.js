import React from 'react';
import PostForm from './PostForm';
import { useNavigate } from 'react-router-dom';

const AddPost = ({ posts, setPosts }) => {
    let navigate = useNavigate();
    const handleOnSubmit = (post) => {
      setPosts([post, ...posts]);
      navigate('/');
    };
  
    return (
      <React.Fragment>
        <PostForm handleOnSubmit={handleOnSubmit} />
      </React.Fragment>
    );
  };
  
  export default AddPost;
import React, { useState, useEffect } from 'react';
import _ from 'lodash';
import Post from './Post';
import axios from 'axios'
import LocalStorage from '../hooks/LocalStorage';
// import { useState } from "react";
// import { Reorder } from "framer-motion";

const PostsList = ({ posts, setPosts }) => {

  useEffect(() => {
    axios.get('https://jsonplaceholder.typicode.com/posts/?_limit=30')
      .then(res => {
        for(let [i, p] of res.data.entries()){
          console.log(p)
          setPosts([p, ...posts])
        }
      })
      .catch(err => {
        console.log('Error getting posts from API', err)
      })
      //setPosts([p, ...posts])
  }, [])

  return (
    // <Reorder.Group axis="y" onReorder={setItems} values={posts1}>
      <React.Fragment>
        <div className="post-list">
          {!_.isEmpty(posts) ? (
            posts.map((post) => (
              <Post key={post.id} {...post} />
            ))
          ) : (
            <p className="message">No posts to show.</p>
          )}
        </div>
      </React.Fragment>
    // </Reorder.Group>
  );
};

export default PostsList;
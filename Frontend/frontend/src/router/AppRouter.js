import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Header from '../components/Header';
import AddPost from '../components/AddPost';
import PostsList from '../components/PostsList';
import EditPost from '../components/EditPost';
import LocalStorage from '../hooks/LocalStorage';

const AppRouter = () => {
  const [posts, setPosts] = LocalStorage('posts', []);

  return (
    <BrowserRouter>
      <div>
        <Header />
        <div className="main-content">
          <Routes>
            <Route path="/" element={<PostsList posts={posts} setPosts={setPosts}></PostsList>} />
            <Route path="/add" element={<AddPost posts={posts} setPosts={setPosts}></AddPost>} />
            <Route path="/edit/:id" element={<EditPost posts={posts} setPosts={setPosts}></EditPost>}></Route>
          </Routes>
        </div>
      </div>
    </BrowserRouter>
  );
};

export default AppRouter;
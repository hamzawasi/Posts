import React, { useState, useEffect } from 'react';
import { NavLink } from 'react-router-dom';
import { Container, Row, Col } from 'react-bootstrap';
import axios from 'axios'

const Header = () => {
  const [userName, setUserName] = useState('');
  const [userEmail, setUserEmail] = useState('');

  useEffect(() => {
    axios.get('https://jsonplaceholder.typicode.com/users/1')
      .then(res => {
        setUserName(res.data.name)
        setUserEmail(res.data.email)
      })
      .catch(err => {
        console.log('Error getting user from API', err)
      })
  }, [])

  return (
    <header>
      <Container>
        <Row>
          <Col>
            <h1>Posts App</h1>
          </Col>
          <Col>
            <h4>{userName}</h4>
            <h4>{userEmail}</h4>
          </Col>
        </Row>
      </Container>

      <hr />
      <div className="links">
        <NavLink to="/" className="link" activeclassname="active" exact="true">
          Posts
        </NavLink>
        <NavLink to="/add" className="link" activeclassname="active">
          Add Post
        </NavLink>
      </div>
    </header>
  );
};

export default Header;
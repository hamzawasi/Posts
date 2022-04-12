import React, { useState } from 'react';
import { Form, Button } from 'react-bootstrap';
import { v4 as uuidv4 } from 'uuid';

const PostForm = (props) => {
    const [post, setPost] = useState(() => {
        return {
            title: props.post ? props.post.title : '',
            body: props.post ? props.post.body : ''
        }
    });

    const [errorMsg, setErrorMsg] = useState('');
    const { title, body } = post;

    const handleOnSubmit = (event) => {
        event.preventDefault();
        const values = [title, body];
        let errorMsg = '';

        const allFieldsFilled = values.every((field) => {
            const value = `${field}`.trim();
            return value !== '' && value !== '0';
        });

        if (allFieldsFilled) {
            const post = {
                userId: 1,
                id: uuidv4(),
                title,
                body
            };
            props.handleOnSubmit(post);
        } else {
            errorMsg = 'Please fill out all the fields.';
        }
        setErrorMsg(errorMsg);
    };

    const handleInputChange = (event) => {
        const { name, value } = event.target;
        setPost((prevState) => ({
            ...prevState,
            [name]: value
        }));
    };

    return (
        <div className="main-form">
            {errorMsg && <p className="errorMsg">{errorMsg}</p>}
            <Form onSubmit={handleOnSubmit}>
                <Form.Group controlId="title">
                    <Form.Label>Title</Form.Label>
                    <Form.Control
                        className="input-control"
                        type="text"
                        name="title"
                        value={title}
                        placeholder="Enter title"
                        onChange={handleInputChange}
                    />
                </Form.Group>
                <Form.Group controlId="body">
                    <Form.Label>Body</Form.Label>
                    <Form.Control
                        className="input-control"
                        type="text"
                        name="body"
                        value={body}
                        placeholder="Enter body"
                        onChange={handleInputChange}
                    />
                </Form.Group>
                <Button variant="primary" type="submit" className="submit-btn">
                    Save
                </Button>
            </Form>
        </div>
    );
};

export default PostForm;
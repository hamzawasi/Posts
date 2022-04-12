import React from 'react';
import { Button, Card } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
// import { useMotionValue, Reorder } from "framer-motion";

const Post = ({
    id,
    title,
    body
}) => {
    let navigate = useNavigate();
    return (
        // <Reorder.Item value={title} id={title}>
            <Card
                style={{ width: '18rem' }}
                className="post">
                <Card.Body>
                    <Card.Title className="post-title">{title}</Card.Title>
                    <div className="post-details">
                        <div>{body}</div>
                    </div>
                    <Button variant="primary" onClick={() => navigate(`/edit/${id}`)}>
                        Edit
                    </Button>{' '}
                </Card.Body>
            </Card>
        // </Reorder.Item>
    );
};

export default Post;
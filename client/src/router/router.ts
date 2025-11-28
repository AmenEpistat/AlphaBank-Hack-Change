import { createBrowserRouter, Navigate } from 'react-router-dom';
import React from 'react';

export const router = createBrowserRouter([
    {
        path: '/',
        element: React.createElement(Navigate, { to: '/list', replace: true }),
    },
]);

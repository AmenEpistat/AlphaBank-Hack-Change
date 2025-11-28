import js from '@eslint/js';
import react from 'eslint-plugin-react';
import ts from '@typescript-eslint/eslint-plugin';
import tsParser from '@typescript-eslint/parser';
import jsxA11y from 'eslint-plugin-jsx-a11y';
import prettier from 'eslint-plugin-prettier';

export default [
    {
        files: ['**/*.{js,jsx,ts,tsx}'],
        languageOptions: {
            ecmaVersion: 'latest',
            sourceType: 'module',
            parser: tsParser,
            parserOptions: {
                ecmaFeatures: { jsx: true },
            },
        },

        plugins: {
            react,
            '@typescript-eslint': ts,
            'jsx-a11y': jsxA11y,
            prettier,
        },

        rules: {
            ...js.configs.recommended.rules,
            ...react.configs.recommended.rules,
            ...ts.configs.recommended.rules,
            ...jsxA11y.configs.recommended.rules,

            'prettier/prettier': [
                'error',
                {
                    semi: true,
                    singleQuote: true,
                    trailingComma: 'es5',
                    bracketSpacing: true,
                    arrowParens: 'always',
                    printWidth: 80,
                    tabWidth: 4,
                    jsxSingleQuote: true,
                },
            ],

            'react/jsx-max-props-per-line': [
                'error',
                { maximum: 1, when: 'always' },
            ],

            'react/self-closing-comp': 'error',

            'jsx-quotes': ['error', 'prefer-single'],

            'react/react-in-jsx-scope': 'off',
        },

        settings: {
            react: { version: 'detect' },
        },
    },
];

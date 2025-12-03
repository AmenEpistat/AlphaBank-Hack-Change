import styles from './logo.module.scss';

const Logo = ({ height = 100, width = 88 }) => {
    return (
        <a href='/lint' target='_blank' rel='noopener noreferrer'>
            <svg
                className={styles.logo}
                fill='currentColor'
                height={height}
                width={width}
                viewBox='0 0 48 48'
                xmlns='http://www.w3.org/2000/svg'
            >
                <path
                    fillRule='evenodd'
                    clipRule='evenodd'
                    d='M23.9607 7.88513L19.7529 20.4108H28.0907L24.1164 7.88513H23.9607ZM24.2723 1C27.6504 1 28.6362 3.01805 29.4914 5.57288L38.3373 32H31.7919L29.8049 25.7173H17.9606L15.8178 32H9.66205L18.9446 5.57288C19.8451 3.00976 20.8942 1 24.2723 1ZM39 46H9V40H39V46Z'
                />
            </svg>
        </a>
    );
};

export default Logo;

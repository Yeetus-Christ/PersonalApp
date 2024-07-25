import { useEffect } from "react";

// 13ad0ec2

const API_URL = 'http://www.omdbapi.com?apikey=13ad0ec2'

const App = () => {
    const searchMovies = async (title) => {
        const response = await fetch(`${API_URL}&s=${title}`);
        const data = await response.json();

        console.log(`${API_URL}&s=${title}`);
        console.log(data);
    }

    useEffect(() => {
        searchMovies('Spider');
    }, []);

    return (
    <h1>App</h1>
    );
}

export default App;
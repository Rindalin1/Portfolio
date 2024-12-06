// Get references to the cells and the reset button
const cells= document.querySelectorAll('.cell');
const resetButton = document.getElementById('resetButton');

//path to the sound

const beBetterSound = new Audio('beBetter.mp3');

//Path to the images

const AtreusImage = 'atreus cell.jpg'
const KratosImage = 'Cell Kratos.jpg'

// Define the game state
let currentPlayer = 'X';  // The player who goes first
let board = Array(9).fill(null); // Empty Board

// Function to handle cell click
function handleClick(event) {
    const cell = event.target; // The clicked cell
    const index = cell.getAttribute('data-index'); // Index of the clicked cell

    // If the cell is already filled or the game is over, do nothing
    if (board[index]  || checkWinner()) return;

    // Update the board and cell content
    board[index] = currentPlayer;
    cell.style.backgroundImage = `url('${currentPlayer === 'X' ? AtreusImage : KratosImage}')`;

    // Check for a winner or a tie
    if(checkWinner())  {
        beBetterSound.play()
        alert(`${currentPlayer === 'X' ? 'Atreus' : 'Kratos'} wins!`, currentPlayer === 'X' ? AtreusImage : KratosImage);
    } else if (board.every(cell => cell)) {
        alert("It's a tie!");
    }

    // Switch players
    currentPlayer = currentPlayer === 'X'  ? 'O' : 'X';
}

// Function to reset the game
function resetGame() {
    board = Array(9).fill(null); // Clear the board
    cells.forEach(cell => cell.style.backgroundImage = ''); //Clear the cell content
    currentPlayer = 'X'; //Reset to player X
}

//Function to check for a winner
 function checkWinner() {
    
    const winningCombos = [
        [0, 1, 2], [3, 4, 5], [6, 7, 8], //Rows
        [0, 3, 6], [1, 4, 7], [2, 5, 8], //Columns
        [0, 4, 8], [2, 4, 6] //Diagonals

    ]
    
    ;

    return winningCombos.some(combo => {
        const [a, b, c] = combo;
        return board[a] && board[a] === board[b] && board[a] === board[c];
    });
}

// Add event listeners to the cells
cells.forEach(cell => cell.addEventListener('click', handleClick));

// Add event listener to the reset button
resetButton.addEventListener('click', resetGame);
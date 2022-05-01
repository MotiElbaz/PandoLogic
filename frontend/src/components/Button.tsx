import { MouseEventHandler } from "react";

interface IButton {
  label: string;
  handleClick: MouseEventHandler<HTMLButtonElement>;
}

const Button = ({handleClick, label} : IButton) => {
  return (
    <button onClick={handleClick} className="btn-search">
      {label}
    </button>
  );
}

export default Button;

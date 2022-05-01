import React, { useState } from 'react';
import Select from 'react-select';
import Button from './Button';

interface ISearch {
  options: any[];
  onSearch: Function;
  stringLength: number;
}

const Search = ({options, onSearch, stringLength} : ISearch ) => {
  const [selectedOption, setSelectedOption] = useState(null);
  const [showOptions, setShowOptions] = useState(false);

  const handleChange = (selectedOption: any) => {
    setSelectedOption(selectedOption);
  };

  const handleInputChange = (value: string) => {
    return value.length >= stringLength ? setShowOptions(true) : setShowOptions(false);
  };

  const handleClick = () => {
    if (selectedOption == null) {
      return alert('You need to select a job title!');
    }
    onSearch(selectedOption['value']);
  };

  return (
    <div className="search-section">
      <Select
        className="search"
        isClearable={true}
        value={selectedOption}
        menuIsOpen={showOptions}
        options={showOptions ? options : []}
        placeholder="Enter a job title"
        onChange={handleChange}
        onInputChange={handleInputChange}
        components={{
          DropdownIndicator: () => null,
          IndicatorSeparator: () => null,
        }}
        theme={(theme) => ({
          ...theme,
          borderRadius: 0,
        })}
      />
      <Button handleClick={handleClick} label={'Search'}></Button>
    </div>
  );
}

export default Search;

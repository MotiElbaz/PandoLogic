interface IList {
  allItems: any[];
  renderFunction: Function;
}

const List = ({allItems, renderFunction} : IList ) => {

  return (
    <ul>
        { allItems.map( (item, index) => renderFunction(item, index) ) }
    </ul>
  );
}

export default List;

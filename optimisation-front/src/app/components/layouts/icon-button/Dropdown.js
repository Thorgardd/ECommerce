import React, { PureComponent, Fragment } from 'react';
import { Menu, Transition } from '@headlessui/react';
import { ChevronDownIcon } from '@heroicons/react/solid';

const filterContent = {
    relevance: "Pertinence",
    crescent: "Prix croissant",
    decrease: "Prix décroissant"
}

function classNames(...classes) {
    return classes.filter(Boolean).join(' ')
}

class Dropdown extends PureComponent {
    constructor(props) {
        super(props);
        this.state = {
            filterValue: filterContent.relevance
        };
    }

    render() {
        return (
            <Menu as="div" className="relative inline-block text-left">
                <div>
                    <Menu.Button className="inline-flex justify-center w-full rounded-md border border-primary-light/[.6] shadow-sm px-4 py-2 bg-white text-sm text-gray-700 hover:bg-primary-light/[.6] focus:outline-none w-40" >
                        {this.state.filterValue}
                        <ChevronDownIcon className="-mr-1 ml-2 h-5 w-5" aria-hidden="true" />
                    </Menu.Button>
                </div>

                <Transition as={Fragment} enter="transition ease-out duration-100" enterFrom="transform opacity-0 scale-95" enterTo="transform opacity-100 scale-100" leave="transition ease-in duration-75" leaveFrom="transform opacity-100 scale-100" leaveTo="transform opacity-0 scale-95" >
                    <Menu.Items className="origin-top-left absolute left-0 mt-2 w-56 rounded-md border border-primary-light/[.6] shadow-lg bg-white ring-1 ring-black ring-opacity-5 focus:outline-none">
                        <div className="py-1">
                            <Menu.Item onClick={() => this.setState({filterValue: filterContent.relevance})}>
                                {({ active }) => (
                                    // eslint-disable-next-line jsx-a11y/anchor-is-valid
                                    <a href="#" className={classNames(active ? "bg-gray-100 text-gray-900" : "text-gray-700", "block px-4 py-2 text-sm")}>
                                        {filterContent.relevance}
                                    </a>
                                )}
                            </Menu.Item>
                            <Menu.Item onClick={() => this.setState({filterValue: filterContent.crescent})}>
                                {({ active }) => (
                                    // eslint-disable-next-line jsx-a11y/anchor-is-valid
                                    <a href="#" className={classNames(active ? "bg-gray-100 text-gray-900" : "text-gray-700", "block px-4 py-2 text-sm")}>
                                        {filterContent.crescent}
                                    </a>
                                )}
                            </Menu.Item>
                            <Menu.Item onClick={() => this.setState({filterValue: filterContent.decrease})}>
                                {({ active }) => (
                                    // eslint-disable-next-line jsx-a11y/anchor-is-valid
                                    <a href="#" className={classNames(active ? "bg-gray-100 text-gray-900" : "text-gray-700", "block px-4 py-2 text-sm")}>
                                        {filterContent.decrease}
                                    </a>
                                )}
                            </Menu.Item>
                        </div>
                    </Menu.Items>
                </Transition>
            </Menu>
        );
    }
}

export default Dropdown;
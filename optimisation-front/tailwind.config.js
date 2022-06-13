module.exports = {
  purge: ['./src/**/*.{js,jsx,ts,tsx}', './public/index.html'],
  content: ["./src/**/*.{html,js,jsx}, ./node_modules/tw-elements/dist/js/**/*.js"],
  darkMode: 'media', // or 'media' or 'class'
  theme: {
    extend: {
      colors: {
        primary: {
          light: '#4ECDC4', /* turquoise (3) */
          DEFAULT: '#0C969F', /* veridian-green */
          dark: '#00767E', /* skobeloff */
        },
        secondary: {
          light: '#FFE790', /* light-yellow */
          DEFAULT: '#FFE790', /* light-yellow */
          dark: '#FFDC62', /* canary-yellow */
        },
        'transparent-cyan': '#DDF5F4',
        'transparent-blue': '#85CACE',
        'green-blue': '#3DCCC9',
        'deep-blue': '#41416E',
        'black-primary': '#343442',
        'black-secondary': '#292F36',
        'red-error': '#E46D6D',
        'light-grey': '#a3a3a3',
        'yellow-button' : "#FFE790"
      },
      transitionProperty: {
        'border': 'border'
      }
    },
    fontFamily: {
      'dosis': ['Dosis'],
      'open-sans': ['Open Sans']
    },
  },
  variants: [
    'responsive',
    'group-hover',
    'focus-within',
    'first',
    'last',
    'odd',
    'even',
    'hover',
    'focus',
    'active',
    'visited',
    'disabled',
  ],
  plugins: [
    require('@tailwindcss/forms'),
    require("@tailwindcss/aspect-ratio")
  ]
}

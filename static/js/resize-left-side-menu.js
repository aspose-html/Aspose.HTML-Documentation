const GUTTER_SIZE = 1;
const MIN_LEFTBAR_SIZE = 12;
const MAX_LEFTBAR_SIZE = 32;
const DEFAULT_LEFT_SIDE_WIDTH = 25;
const DEFAULT_RIGHT_SIDE_WIDTH = 75;

var leftSideId = '#left-side-bar-menu';
var rightSideId = '#right-side';
var gutterId = '#sidebar-resizer';

function saveLeftSideWidth() {
  localStorage.setItem("lefSideWidth", getLefSideWidth());
}

function clearStyles(objectId, classToRemove) {
  $(objectId).removeAttr("style");
  $(objectId).removeClass(classToRemove);
}

function setStyles(objectId, classToAdd) {
  if(!$(objectId).hasClass(classToAdd)) {
    $(objectId).addClass(classToAdd);
  }
}

function setGutterHeight() {
  $(gutterId).css('height', $(rightSideId).height());
}

function calcLeftFotGutter() {
  
  return GUTTER_SIZE + $(leftSideId).width() + 15 + 'px';
}

function getLefSideWidth() {
  return $(leftSideId).width() / $(window).width() * 100;
}

function calcGutterPosition() {
  if(getLefSideWidth() < MAX_LEFTBAR_SIZE && getLefSideWidth() > MIN_LEFTBAR_SIZE) {      
    $(gutterId).css('left', calcLeftFotGutter());
  }
  if(getLefSideWidth() > MAX_LEFTBAR_SIZE) {
    $(gutterId).css('left', '32%');
  }
  if(getLefSideWidth() < MIN_LEFTBAR_SIZE) {
      $(gutterId).css('left', `calc(${getLefSideWidth()} + 1px)`);
  }
}

function setGutterStyles(gutterElementId) {
  $(gutterElementId).show();
  $(gutterElementId).css('padding', `0.01rem`);
  $(gutterElementId).css('left', calcLeftFotGutter());
  setGutterHeight();
  $(gutterElementId).css('cursor', 'ew-resize');
}

function removeStylesDependingOnWindowWidth() {
  if ($( window ).width() < 768 ) {
    $(gutterId).hide();
    clearStyles(leftSideId, "leftSideBarSize");
    clearStyles(rightSideId, "rightSideContent");
  } else {
    setGutterStyles(gutterId);

    setStyles(leftSideId, "leftSideBarSize");
    setStyles(rightSideId, "rightSideContent");
    
    split();
  }
}

var split = function (leftSideWidth, rightSideWidth) {
  Split([leftSideId, rightSideId], {
  sizes: [leftSideWidth, rightSideWidth],
  elementStyle: (dimension, size, gutterSize) => ({

      'flex': `0 0 calc(${size}% - ${GUTTER_SIZE/2}px)`,
  }),
  gutterStyle: (dimension, gutterSize) => ({
    'left': calcLeftFotGutter()
  }),
  onDrag: function(dimension, size, gutterSize) {
    calcGutterPosition();
  }, 
  onDragEnd: function(size, gutterSize) {
    calcGutterPosition();
    setGutterHeight();
    saveLeftSideWidth();
  },
    gutter: (index, direction) => {
      const gutter = document.getElementById('sidebar-resizer');
      gutter.className = `gutter gutter-${direction}`
      return gutter
  }
});
}

if($(leftSideId).length != 0)
{
  var leftSideWidth = Math.round(localStorage.getItem("lefSideWidth")) + 1;
  if (leftSideWidth) {
    split(leftSideWidth, 100 - leftSideWidth);
  } else {
    split(DEFAULT_LEFT_SIDE_WIDTH, DEFAULT_RIGHT_SIDE_WIDTH);
  }
  removeStylesDependingOnWindowWidth();

  $( window ).resize(function() {
    removeStylesDependingOnWindowWidth();
  });
}
$(leftSideId).addClass("col-12 col-md-3 col-xl-3");
if($(leftSideId)!= null & $(rightSideId)!= null) {
  $(leftSideId).show();
  $(rightSideId).show();
}
setGutterHeight();
setTimeout($(gutterId).css('left', calcLeftFotGutter()), 1000);

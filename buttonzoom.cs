new ActionMap(zoomerMap);
$minFov = 20;
$maxFov = 120;
$currentFov = 70;
function changeFovPlus()
{
    if ($currentFov < $maxFov)
    {
        $currentFov = $currentFov + 1;
        setFov(($currentFov));
    }
}
function changeFovMinus()
{
    if ($currentFov > $minFov)
    {
        $currentFov = $currentFov - 1;
        setFov(($currentFov));
    }
}
function mouseZoom(%val)
{
        if (%val > 1)
        {
            changeFovPlus();
        }
        else
        {
            changeFovMinus();
        }
}

zoomerMap.bind(keyboard, "numpadminus", changeFovPlus);
zoomerMap.bind(keyboard, "numpadadd", changeFovMinus);

zoomerMap.push();
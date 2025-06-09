using Microsoft.AspNetCore.Components;
using BlazorDashboardClean.Enums;

public class HeroIconBase : ComponentBase
{
    protected static readonly Dictionary<HeroIconName, string> HeroIconMap = new()
{
    { HeroIconName.Close, @"<!-- SVG for x-mark goes here -->" },
    { HeroIconName.CircleClose, @"<!-- SVG for x-circle goes here -->" },
    { HeroIconName.UserPlus, @"<!-- SVG for user-plus goes here -->" },
    { HeroIconName.Users, @"<!-- SVG for users goes here -->" },
    { HeroIconName.UserCircle, @"<!-- SVG for user-circle goes here -->" },
    { HeroIconName.ReceiptPercent, @"<!-- SVG for receipt-percent goes here -->" },
    { HeroIconName.PlusCircle, @"<!-- SVG for plus-circle goes here -->" },
    { HeroIconName.PercentBadge, @"<!-- SVG for percent-badge goes here -->" },
    { HeroIconName.PencilSquare, @"<!-- SVG for pencil-square goes here -->" },
    { HeroIconName.NoSymbol, @"<!-- SVG for no-symbol goes here -->" },
    { HeroIconName.MapPin, @"<!-- SVG for map-pin goes here -->" },
    { HeroIconName.MagnifyingGlass, @"<!-- SVG for magnifying-glass goes here -->" },
    { HeroIconName.InformationCircle, @"<!-- SVG for information-circle goes here -->" },
    { HeroIconName.ExclamationTriangle, @"<!-- SVG for exclamation-triangle goes here -->" },
    { HeroIconName.ExclamationCircle, @"<!-- SVG for exclamation-circle goes here -->" },
    { HeroIconName.EllipsisHorizontal, @"<!-- SVG for ellipsis-horizontal goes here -->" },
    { HeroIconName.EllipsisVertical, @"<!-- SVG for ellipsis-vertical goes here -->" },
    { HeroIconName.EllipsisHorizontalCircle, @"<!-- SVG for ellipsis-horizontal-circle goes here -->" },
    { HeroIconName.DocumentArrowDown, @"<!-- SVG for document-arrow-down goes here -->" },
    { HeroIconName.DocumentArrowUp, @"<!-- SVG for document-arrow-up goes here -->" },
    { HeroIconName.Settings, @"<svg xmlns='http://www.w3.org/2000/svg' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M9.594 3.94c.09-.542.56-.94 1.11-.94h2.593c.55 0 1.02.398 1.11.94l.213 1.281c.063.374.313.686.645.87.074.04.147.083.22.127.325.196.72.257 1.075.124l1.217-.456a1.125 1.125 0 0 1 1.37.49l1.296 2.247a1.125 1.125 0 0 1-.26 1.431l-1.003.827c-.293.241-.438.613-.43.992a7.723 7.723 0 0 1 0 .255c-.008.378.137.75.43.991l1.004.827c.424.35.534.955.26 1.43l-1.298 2.247a1.125 1.125 0 0 1-1.369.491l-1.217-.456c-.355-.133-.75-.072-1.076.124a6.47 6.47 0 0 1-.22.128c-.331.183-.581.495-.644.869l-.213 1.281c-.09.543-.56.94-1.11.94h-2.594c-.55 0-1.019-.398-1.11-.94l-.213-1.281c-.062-.374-.312-.686-.644-.87a6.52 6.52 0 0 1-.22-.127c-.325-.196-.72-.257-1.076-.124l-1.217.456a1.125 1.125 0 0 1-1.369-.49l-1.297-2.247a1.125 1.125 0 0 1 .26-1.431l1.004-.827c.292-.24.437-.613.43-.991a6.932 6.932 0 0 1 0-.255c.007-.38-.138-.751-.43-.992l-1.004-.827a1.125 1.125 0 0 1-.26-1.43l1.297-2.247a1.125 1.125 0 0 1 1.37-.491l1.216.456c.356.133.751.072 1.076-.124.072-.044.146-.086.22-.128.332-.183.582-.495.644-.869l.214-1.28Z' /><path stroke-linecap='round' stroke-linejoin='round' d='M15 12a3 3 0 1 1-6 0 3 3 0 0 1 6 0Z' /></svg>" }
,
    { HeroIconName.ChevronUp, @"<!-- SVG for chevron-up goes here -->" },
    { HeroIconName.CheckCircle, @"<!-- SVG for check-circle goes here -->" },
    { HeroIconName.Check, @"<!-- SVG for check goes here -->" },
    { HeroIconName.Bell, @"<!-- SVG for bell goes here -->" },
    { HeroIconName.Power, @"<!-- SVG for power goes here -->" },
    { HeroIconName.Plus, @"<!-- SVG for plus goes here -->" },
    { HeroIconName.Trash, @"<!-- SVG for trash goes here -->" },
};

}

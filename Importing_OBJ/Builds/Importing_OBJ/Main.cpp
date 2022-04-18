#include "pch.h"
#include "App.h"
#include <HolographicAppRemoting/StreamerHybridPlayer.h>

struct RoInitializeWrapper
{
    inline RoInitializeWrapper() { RoInitialize(RO_INIT_MULTITHREADED); }
    inline ~RoInitializeWrapper() { RoUninitialize(); }
};

int CALLBACK wWinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPWSTR lpCmdLine, int nCmdShow)
{
    RoInitializeWrapper roInit;
    HolographicStreamerHybridPlayerOpenXrInit();

    Windows::ApplicationModel::Core::CoreApplication::Run(ref new Importing_OBJ::App());
    return 0;
}

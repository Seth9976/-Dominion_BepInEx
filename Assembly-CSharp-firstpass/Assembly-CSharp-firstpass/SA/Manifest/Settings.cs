using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Manifest
{
	// Token: 0x02000320 RID: 800
	public class Settings : Object
	{
		// Token: 0x06002F25 RID: 12069 RVA: 0x000C970C File Offset: 0x000C790C
		// Note: this type is marked as 'beforefieldinit'.
		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Manifest", "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			Settings.NativeFieldInfoPtr_VERSION_NUMBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "VERSION_NUMBER");
			Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100669537);
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x000C9764 File Offset: 0x000C7964
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Settings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x0001207F File Offset: 0x0001027F
		public Settings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x000C97A0 File Offset: 0x000C79A0
		// (set) Token: 0x06002F29 RID: 12073 RVA: 0x00012088 File Offset: 0x00010288
		public unsafe static string VERSION_NUMBER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_VERSION_NUMBER, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_VERSION_NUMBER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002CEB RID: 11499
		private static readonly IntPtr NativeFieldInfoPtr_VERSION_NUMBER;

		// Token: 0x04002CEC RID: 11500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

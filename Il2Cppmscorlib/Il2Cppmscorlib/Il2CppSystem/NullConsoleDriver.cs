using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000125 RID: 293
	public class NullConsoleDriver : Object
	{
		// Token: 0x060014CA RID: 5322 RVA: 0x00080C8C File Offset: 0x0007EE8C
		// Note: this type is marked as 'beforefieldinit'.
		static NullConsoleDriver()
		{
			Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NullConsoleDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr);
			NullConsoleDriver.NativeFieldInfoPtr_EmptyConsoleKeyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, "EmptyConsoleKeyInfo");
			NullConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, 100666842);
			NullConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, 100666843);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00080CF8 File Offset: 0x0007EEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306343, XrefRangeEnd = 306347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00080D44 File Offset: 0x0007EF44
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullConsoleDriver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0000743C File Offset: 0x0000563C
		public NullConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x00080D80 File Offset: 0x0007EF80
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x00007445 File Offset: 0x00005645
		public unsafe static ConsoleKeyInfo EmptyConsoleKeyInfo
		{
			get
			{
				ConsoleKeyInfo consoleKeyInfo;
				IL2CPP.il2cpp_field_static_get_value(NullConsoleDriver.NativeFieldInfoPtr_EmptyConsoleKeyInfo, (void*)(&consoleKeyInfo));
				return consoleKeyInfo;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullConsoleDriver.NativeFieldInfoPtr_EmptyConsoleKeyInfo, (void*)(&value));
			}
		}

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeFieldInfoPtr_EmptyConsoleKeyInfo;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

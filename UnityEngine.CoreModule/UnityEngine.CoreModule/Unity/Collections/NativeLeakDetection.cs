using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200001C RID: 28
	public static class NativeLeakDetection : Object
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00018854 File Offset: 0x00016A54
		// Note: this type is marked as 'beforefieldinit'.
		static NativeLeakDetection()
		{
			Il2CppClassPointerStore<NativeLeakDetection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeLeakDetection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeLeakDetection>.NativeClassPtr);
			NativeLeakDetection.NativeFieldInfoPtr_s_NativeLeakDetectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeLeakDetection>.NativeClassPtr, "s_NativeLeakDetectionMode");
			NativeLeakDetection.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeLeakDetection>.NativeClassPtr, 100663314);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000188AC File Offset: 0x00016AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58991, XrefRangeEnd = 58993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeLeakDetection.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000028BD File Offset: 0x00000ABD
		public NativeLeakDetection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000188D4 File Offset: 0x00016AD4
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000028C6 File Offset: 0x00000AC6
		public unsafe static int s_NativeLeakDetectionMode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NativeLeakDetection.NativeFieldInfoPtr_s_NativeLeakDetectionMode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeLeakDetection.NativeFieldInfoPtr_s_NativeLeakDetectionMode, (void*)(&value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000188F0 File Offset: 0x00016AF0
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0001891C File Offset: 0x00016B1C
		public static NativeLeakDetectionMode Mode
		{
			get
			{
				bool flag = NativeLeakDetection.s_NativeLeakDetectionMode == 0;
				if (flag)
				{
					NativeLeakDetection.Initialize();
				}
				return (NativeLeakDetectionMode)NativeLeakDetection.s_NativeLeakDetectionMode;
			}
			set
			{
				bool flag = NativeLeakDetection.s_NativeLeakDetectionMode != (int)value;
				if (flag)
				{
					NativeLeakDetection.s_NativeLeakDetectionMode = (int)value;
				}
			}
		}

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_s_NativeLeakDetectionMode;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

		// Token: 0x0400008B RID: 139
		public const string kNativeLeakDetectionModePrefsString = "Unity.Colletions.NativeLeakDetection.Mode";
	}
}

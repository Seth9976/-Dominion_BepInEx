using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000012 RID: 18
	public static class TMP_Math : global::Il2CppSystem.Object
	{
		// Token: 0x0600021F RID: 543 RVA: 0x00011880 File Offset: 0x0000FA80
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Math()
		{
			Il2CppClassPointerStore<TMP_Math>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Math");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr);
			TMP_Math.NativeFieldInfoPtr_FLOAT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_MAX");
			TMP_Math.NativeFieldInfoPtr_FLOAT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_MIN");
			TMP_Math.NativeFieldInfoPtr_INT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_MAX");
			TMP_Math.NativeFieldInfoPtr_INT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_MIN");
			TMP_Math.NativeFieldInfoPtr_FLOAT_UNSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_UNSET");
			TMP_Math.NativeFieldInfoPtr_INT_UNSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_UNSET");
			TMP_Math.NativeFieldInfoPtr_MAX_16BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "MAX_16BIT");
			TMP_Math.NativeFieldInfoPtr_MIN_16BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "MIN_16BIT");
			TMP_Math.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, 100663555);
			TMP_Math.NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, 100663556);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00011978 File Offset: 0x0000FB78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137411, RefRangeEnd = 137413, XrefRangeStart = 137411, XrefRangeEnd = 137411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Math.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000119C4 File Offset: 0x0000FBC4
		[CallerCount(0)]
		public unsafe static int Mod(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Math.NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002CBE File Offset: 0x00000EBE
		public TMP_Math(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00011A10 File Offset: 0x0000FC10
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002CC7 File Offset: 0x00000EC7
		public unsafe static float FLOAT_MAX
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MAX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MAX, (void*)(&value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00011A2C File Offset: 0x0000FC2C
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002CD5 File Offset: 0x00000ED5
		public unsafe static float FLOAT_MIN
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MIN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MIN, (void*)(&value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00011A48 File Offset: 0x0000FC48
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002CE3 File Offset: 0x00000EE3
		public unsafe static int INT_MAX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_INT_MAX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_INT_MAX, (void*)(&value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00011A64 File Offset: 0x0000FC64
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002CF1 File Offset: 0x00000EF1
		public unsafe static int INT_MIN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_INT_MIN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_INT_MIN, (void*)(&value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00011A80 File Offset: 0x0000FC80
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00002CFF File Offset: 0x00000EFF
		public unsafe static float FLOAT_UNSET
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_FLOAT_UNSET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_FLOAT_UNSET, (void*)(&value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00011A9C File Offset: 0x0000FC9C
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00002D0D File Offset: 0x00000F0D
		public unsafe static int INT_UNSET
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_INT_UNSET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_INT_UNSET, (void*)(&value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002D1B File Offset: 0x00000F1B
		public unsafe static Vector2 MAX_16BIT
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_MAX_16BIT, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_MAX_16BIT, (void*)(&value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00011AD4 File Offset: 0x0000FCD4
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00002D29 File Offset: 0x00000F29
		public unsafe static Vector2 MIN_16BIT
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_MIN_16BIT, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_MIN_16BIT, (void*)(&value));
			}
		}

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_FLOAT_MAX;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_FLOAT_MIN;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_INT_MAX;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_INT_MIN;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_FLOAT_UNSET;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_INT_UNSET;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_MAX_16BIT;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_MIN_16BIT;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0;
	}
}

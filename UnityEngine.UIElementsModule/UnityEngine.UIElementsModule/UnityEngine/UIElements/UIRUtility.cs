using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AB RID: 171
	public static class UIRUtility : Object
	{
		// Token: 0x060008DB RID: 2267 RVA: 0x00029358 File Offset: 0x00027558
		// Note: this type is marked as 'beforefieldinit'.
		static UIRUtility()
		{
			Il2CppClassPointerStore<UIRUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIRUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr);
			UIRUtility.NativeFieldInfoPtr_k_DefaultShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, "k_DefaultShaderName");
			UIRUtility.NativeFieldInfoPtr_k_DefaultWorldSpaceShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, "k_DefaultWorldSpaceShaderName");
			UIRUtility.NativeMethodInfoPtr_Multiply2D_Public_Static_Void_Quaternion_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, 100664152);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000293C4 File Offset: 0x000275C4
		[CallerCount(0)]
		public unsafe static void Multiply2D(this Quaternion rotation, ref Vector2 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRUtility.NativeMethodInfoPtr_Multiply2D_Public_Static_Void_Quaternion_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00005BDC File Offset: 0x00003DDC
		public UIRUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00029404 File Offset: 0x00027604
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00005BE5 File Offset: 0x00003DE5
		public unsafe static string k_DefaultShaderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIRUtility.NativeFieldInfoPtr_k_DefaultShaderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRUtility.NativeFieldInfoPtr_k_DefaultShaderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00029424 File Offset: 0x00027624
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00005BF7 File Offset: 0x00003DF7
		public unsafe static string k_DefaultWorldSpaceShaderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIRUtility.NativeFieldInfoPtr_k_DefaultWorldSpaceShaderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRUtility.NativeFieldInfoPtr_k_DefaultWorldSpaceShaderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00029444 File Offset: 0x00027644
		public static Vector4 ToVector4(Rect rc)
		{
			return new Vector4(rc.xMin, rc.yMin, rc.xMax, rc.yMax);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00029478 File Offset: 0x00027678
		public static bool IsRoundRect(VisualElement ve)
		{
			IResolvedStyle resolvedStyle = ve.resolvedStyle;
			return resolvedStyle.borderTopLeftRadius >= Mathf.Epsilon || resolvedStyle.borderTopRightRadius >= Mathf.Epsilon || resolvedStyle.borderBottomLeftRadius >= Mathf.Epsilon || resolvedStyle.borderBottomRightRadius >= Mathf.Epsilon;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000294CC File Offset: 0x000276CC
		public static bool IsVectorImageBackground(VisualElement ve)
		{
			Background backgroundImage = ve.computedStyle.backgroundImage;
			return backgroundImage.vectorImage != null;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000294F8 File Offset: 0x000276F8
		public static void Destroy(Object obj)
		{
			bool flag = obj == null;
			if (!flag)
			{
				bool isPlaying = Application.isPlaying;
				if (isPlaying)
				{
					Object.Destroy(obj);
				}
				else
				{
					Object.DestroyImmediate(obj);
				}
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0002952C File Offset: 0x0002772C
		public static int GetPrevPow2(int n)
		{
			int num = 0;
			while (n > 1)
			{
				n >>= 1;
				num++;
			}
			return 1 << num;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0002955C File Offset: 0x0002775C
		public static int GetNextPow2(int n)
		{
			int i;
			for (i = 1; i < n; i <<= 1)
			{
			}
			return i;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00029580 File Offset: 0x00027780
		public static int GetNextPow2Exp(int n)
		{
			int i = 1;
			int num = 0;
			while (i < n)
			{
				i <<= 1;
				num++;
			}
			return num;
		}

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultShaderName;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultWorldSpaceShaderName;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_Multiply2D_Public_Static_Void_Quaternion_byref_Vector2_0;

		// Token: 0x04000502 RID: 1282
		public const float k_ClearZ = 0.99f;

		// Token: 0x04000503 RID: 1283
		public const float k_MeshPosZ = 0f;

		// Token: 0x04000504 RID: 1284
		public const float k_MaskPosZ = 1f;
	}
}

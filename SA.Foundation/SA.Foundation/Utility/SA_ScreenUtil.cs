using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace SA.Foundation.Utility
{
	// Token: 0x02000019 RID: 25
	public static class SA_ScreenUtil : global::Il2CppSystem.Object
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00006958 File Offset: 0x00004B58
		// Note: this type is marked as 'beforefieldinit'.
		static SA_ScreenUtil()
		{
			Il2CppClassPointerStore<SA_ScreenUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Utility", "SA_ScreenUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ScreenUtil>.NativeClassPtr);
			SA_ScreenUtil.NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil>.NativeClassPtr, 100663424);
			SA_ScreenUtil.NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Int32_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil>.NativeClassPtr, 100663425);
			SA_ScreenUtil.NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Camera_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil>.NativeClassPtr, 100663426);
			SA_ScreenUtil.NativeMethodInfoPtr_TakeScreenshotCoroutine_Private_Static_IEnumerator_Int32_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil>.NativeClassPtr, 100663427);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000069D8 File Offset: 0x00004BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99244, XrefRangeEnd = 99250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TakeScreenshot(Action<Texture2D> callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil.NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Action_1_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006A10 File Offset: 0x00004C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99250, XrefRangeEnd = 99252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TakeScreenshot(int maxSize, Action<Texture2D> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil.NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Int32_Action_1_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006A54 File Offset: 0x00004C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99252, XrefRangeEnd = 99263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TakeScreenshot(Camera camera, Action<Texture2D> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil.NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Camera_Action_1_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006A9C File Offset: 0x00004C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99267, RefRangeEnd = 99268, XrefRangeStart = 99263, XrefRangeEnd = 99267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator TakeScreenshotCoroutine(int maxSize, Action<Texture2D> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil.NativeMethodInfoPtr_TakeScreenshotCoroutine_Private_Static_IEnumerator_Int32_Action_1_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002225 File Offset: 0x00000425
		public SA_ScreenUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Action_1_Texture2D_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Int32_Action_1_Texture2D_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Camera_Action_1_Texture2D_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_TakeScreenshotCoroutine_Private_Static_IEnumerator_Int32_Action_1_Texture2D_0;

		// Token: 0x0200004B RID: 75
		public class CameraScreenshot : MonoBehaviour
		{
			// Token: 0x060003C1 RID: 961 RVA: 0x00012DCC File Offset: 0x00010FCC
			// Note: this type is marked as 'beforefieldinit'.
			static CameraScreenshot()
			{
				Il2CppClassPointerStore<SA_ScreenUtil.CameraScreenshot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_ScreenUtil>.NativeClassPtr, "CameraScreenshot");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ScreenUtil.CameraScreenshot>.NativeClassPtr);
				SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_m_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScreenUtil.CameraScreenshot>.NativeClassPtr, "m_camera");
				SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_m_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScreenUtil.CameraScreenshot>.NativeClassPtr, "m_callback");
				SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_resWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScreenUtil.CameraScreenshot>.NativeClassPtr, "resWidth");
				SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_resHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScreenUtil.CameraScreenshot>.NativeClassPtr, "resHeight");
				SA_ScreenUtil.CameraScreenshot.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil.CameraScreenshot>.NativeClassPtr, 100663878);
				SA_ScreenUtil.CameraScreenshot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil.CameraScreenshot>.NativeClassPtr, 100663879);
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x00012E70 File Offset: 0x00011070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99207, XrefRangeEnd = 99232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void LateUpdate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil.CameraScreenshot.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x00012EA4 File Offset: 0x000110A4
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraScreenshot()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ScreenUtil.CameraScreenshot>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil.CameraScreenshot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x00002F8F File Offset: 0x0000118F
			public CameraScreenshot(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060003C5 RID: 965 RVA: 0x00012EE0 File Offset: 0x000110E0
			// (set) Token: 0x060003C6 RID: 966 RVA: 0x00002F98 File Offset: 0x00001198
			public unsafe Camera m_camera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_m_camera);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_m_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060003C7 RID: 967 RVA: 0x00012F10 File Offset: 0x00011110
			// (set) Token: 0x060003C8 RID: 968 RVA: 0x00002FB7 File Offset: 0x000011B7
			public unsafe Action<Texture2D> m_callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_m_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_m_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x060003C9 RID: 969 RVA: 0x00012F40 File Offset: 0x00011140
			// (set) Token: 0x060003CA RID: 970 RVA: 0x00002FD6 File Offset: 0x000011D6
			public unsafe int resWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_resWidth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_resWidth)) = value;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x060003CB RID: 971 RVA: 0x00012F68 File Offset: 0x00011168
			// (set) Token: 0x060003CC RID: 972 RVA: 0x00002FF1 File Offset: 0x000011F1
			public unsafe int resHeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_resHeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil.CameraScreenshot.NativeFieldInfoPtr_resHeight)) = value;
				}
			}

			// Token: 0x040002EE RID: 750
			private static readonly IntPtr NativeFieldInfoPtr_m_camera;

			// Token: 0x040002EF RID: 751
			private static readonly IntPtr NativeFieldInfoPtr_m_callback;

			// Token: 0x040002F0 RID: 752
			private static readonly IntPtr NativeFieldInfoPtr_resWidth;

			// Token: 0x040002F1 RID: 753
			private static readonly IntPtr NativeFieldInfoPtr_resHeight;

			// Token: 0x040002F2 RID: 754
			private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

			// Token: 0x040002F3 RID: 755
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200004C RID: 76
		[ObfuscatedName("SA.Foundation.Utility.SA_ScreenUtil+<TakeScreenshotCoroutine>d__3")]
		public sealed class _TakeScreenshotCoroutine_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x060003CD RID: 973 RVA: 0x00012F90 File Offset: 0x00011190
			// Note: this type is marked as 'beforefieldinit'.
			static _TakeScreenshotCoroutine_d__3()
			{
				Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_ScreenUtil>.NativeClassPtr, "<TakeScreenshotCoroutine>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr);
				SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr, "<>1__state");
				SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr, "<>2__current");
				SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr, "maxSize");
				SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr, "callback");
				SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr, 100663880);
				SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr, 100663881);
				SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr, 100663882);
				SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr, 100663883);
				SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr, 100663884);
				SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr, 100663885);
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00013084 File Offset: 0x00011284
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TakeScreenshotCoroutine_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ScreenUtil._TakeScreenshotCoroutine_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003CF RID: 975 RVA: 0x000130CC File Offset: 0x000112CC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00013100 File Offset: 0x00011300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99232, XrefRangeEnd = 99239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x0001313C File Offset: 0x0001133C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x0001317C File Offset: 0x0001137C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99239, XrefRangeEnd = 99244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x060003D3 RID: 979 RVA: 0x000131B0 File Offset: 0x000113B0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x0000300C File Offset: 0x0000120C
			public _TakeScreenshotCoroutine_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x060003D5 RID: 981 RVA: 0x000131F0 File Offset: 0x000113F0
			// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003015 File Offset: 0x00001215
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x00013218 File Offset: 0x00011418
			// (set) Token: 0x060003D8 RID: 984 RVA: 0x00003030 File Offset: 0x00001230
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060003D9 RID: 985 RVA: 0x00013248 File Offset: 0x00011448
			// (set) Token: 0x060003DA RID: 986 RVA: 0x0000304F File Offset: 0x0000124F
			public unsafe int maxSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr_maxSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr_maxSize)) = value;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060003DB RID: 987 RVA: 0x00013270 File Offset: 0x00011470
			// (set) Token: 0x060003DC RID: 988 RVA: 0x0000306A File Offset: 0x0000126A
			public unsafe Action<Texture2D> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScreenUtil._TakeScreenshotCoroutine_d__3.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002F4 RID: 756
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002F5 RID: 757
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002F6 RID: 758
			private static readonly IntPtr NativeFieldInfoPtr_maxSize;

			// Token: 0x040002F7 RID: 759
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040002F8 RID: 760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002F9 RID: 761
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002FA RID: 762
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002FB RID: 763
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002FC RID: 764
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002FD RID: 765
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

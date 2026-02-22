using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000068 RID: 104
	public class BaseInput : UIBehaviour
	{
		// Token: 0x06000A41 RID: 2625 RVA: 0x0002E8EC File Offset: 0x0002CAEC
		// Note: this type is marked as 'beforefieldinit'.
		static BaseInput()
		{
			Il2CppClassPointerStore<BaseInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "BaseInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseInput>.NativeClassPtr);
			BaseInput.NativeMethodInfoPtr_get_compositionString_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664793);
			BaseInput.NativeMethodInfoPtr_get_imeCompositionMode_Public_Virtual_New_get_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664794);
			BaseInput.NativeMethodInfoPtr_set_imeCompositionMode_Public_Virtual_New_set_Void_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664795);
			BaseInput.NativeMethodInfoPtr_get_compositionCursorPos_Public_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664796);
			BaseInput.NativeMethodInfoPtr_set_compositionCursorPos_Public_Virtual_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664797);
			BaseInput.NativeMethodInfoPtr_get_mousePresent_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664798);
			BaseInput.NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664799);
			BaseInput.NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664800);
			BaseInput.NativeMethodInfoPtr_GetMouseButton_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664801);
			BaseInput.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664802);
			BaseInput.NativeMethodInfoPtr_get_mouseScrollDelta_Public_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664803);
			BaseInput.NativeMethodInfoPtr_get_touchSupported_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664804);
			BaseInput.NativeMethodInfoPtr_get_touchCount_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664805);
			BaseInput.NativeMethodInfoPtr_GetTouch_Public_Virtual_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664806);
			BaseInput.NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_New_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664807);
			BaseInput.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664808);
			BaseInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInput>.NativeClassPtr, 100664809);
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0002EA70 File Offset: 0x0002CC70
		public unsafe virtual string compositionString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122082, XrefRangeEnd = 122083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_get_compositionString_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0002EAB4 File Offset: 0x0002CCB4
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x0002EAFC File Offset: 0x0002CCFC
		public unsafe virtual IMECompositionMode imeCompositionMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122083, XrefRangeEnd = 122084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_get_imeCompositionMode_Public_Virtual_New_get_IMECompositionMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122084, XrefRangeEnd = 122085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_set_imeCompositionMode_Public_Virtual_New_set_Void_IMECompositionMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0002EB48 File Offset: 0x0002CD48
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0002EB90 File Offset: 0x0002CD90
		public unsafe virtual Vector2 compositionCursorPos
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122085, XrefRangeEnd = 122086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_get_compositionCursorPos_Public_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122086, XrefRangeEnd = 122087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_set_compositionCursorPos_Public_Virtual_New_set_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0002EBDC File Offset: 0x0002CDDC
		public unsafe virtual bool mousePresent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122087, XrefRangeEnd = 122088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_get_mousePresent_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002EC24 File Offset: 0x0002CE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122088, XrefRangeEnd = 122089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetMouseButtonDown(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002EC78 File Offset: 0x0002CE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122089, XrefRangeEnd = 122090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetMouseButtonUp(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002ECCC File Offset: 0x0002CECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122090, XrefRangeEnd = 122091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetMouseButton(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_GetMouseButton_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0002ED20 File Offset: 0x0002CF20
		public unsafe virtual Vector2 mousePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122091, XrefRangeEnd = 122092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0002ED68 File Offset: 0x0002CF68
		public unsafe virtual Vector2 mouseScrollDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122092, XrefRangeEnd = 122093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_get_mouseScrollDelta_Public_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
		public unsafe virtual bool touchSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122093, XrefRangeEnd = 122094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_get_touchSupported_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0002EDF8 File Offset: 0x0002CFF8
		public unsafe virtual int touchCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122094, XrefRangeEnd = 122095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_get_touchCount_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0002EE40 File Offset: 0x0002D040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122095, XrefRangeEnd = 122096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Touch GetTouch(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_GetTouch_Public_Virtual_New_Touch_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002EE94 File Offset: 0x0002D094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122096, XrefRangeEnd = 122097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetAxisRaw(string axisName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_New_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0002EEEC File Offset: 0x0002D0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122097, XrefRangeEnd = 122098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDown(string buttonName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInput.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0002EF44 File Offset: 0x0002D144
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00005ACD File Offset: 0x00003CCD
		public BaseInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Public_Virtual_New_get_String_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_get_imeCompositionMode_Public_Virtual_New_get_IMECompositionMode_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_set_imeCompositionMode_Public_Virtual_New_set_Void_IMECompositionMode_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionCursorPos_Public_Virtual_New_get_Vector2_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Public_Virtual_New_set_Void_Vector2_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePresent_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButton_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Virtual_New_get_Vector2_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Public_Virtual_New_get_Vector2_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_get_touchSupported_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Virtual_New_get_Int32_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Virtual_New_Touch_Int32_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_New_Single_String_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Virtual_New_Boolean_String_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

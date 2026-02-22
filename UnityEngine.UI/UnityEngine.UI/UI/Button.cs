using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000003 RID: 3
	public class Button : Selectable
	{
		// Token: 0x06000022 RID: 34 RVA: 0x0000779C File Offset: 0x0000599C
		// Note: this type is marked as 'beforefieldinit'.
		static Button()
		{
			Il2CppClassPointerStore<Button>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Button");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button>.NativeClassPtr);
			Button.NativeFieldInfoPtr_m_OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "m_OnClick");
			Button.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663308);
			Button.NativeMethodInfoPtr_get_onClick_Public_get_ButtonClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663309);
			Button.NativeMethodInfoPtr_set_onClick_Public_set_Void_ButtonClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663310);
			Button.NativeMethodInfoPtr_Press_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663311);
			Button.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663312);
			Button.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663313);
			Button.NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663314);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000786C File Offset: 0x00005A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108019, XrefRangeEnd = 108027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Button()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000078A8 File Offset: 0x00005AA8
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000078E8 File Offset: 0x00005AE8
		public unsafe Button.ButtonClickedEvent onClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_get_onClick_Public_get_ButtonClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Button.ButtonClickedEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_set_onClick_Public_set_Void_ButtonClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000792C File Offset: 0x00005B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108031, RefRangeEnd = 108033, XrefRangeStart = 108027, XrefRangeEnd = 108031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Press()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_Press_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00007960 File Offset: 0x00005B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108033, XrefRangeEnd = 108034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Button.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000079B0 File Offset: 0x00005BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108034, XrefRangeEnd = 108040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Button.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00007A00 File Offset: 0x00005C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108040, XrefRangeEnd = 108044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnFinishSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000214E File Offset: 0x0000034E
		public Button(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00007A40 File Offset: 0x00005C40
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002157 File Offset: 0x00000357
		public unsafe Button.ButtonClickedEvent m_OnClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_m_OnClick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button.ButtonClickedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_m_OnClick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_m_OnClick;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_onClick_Public_get_ButtonClickedEvent_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_set_onClick_Public_set_Void_ButtonClickedEvent_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_Press_Private_Void_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0;

		// Token: 0x02000075 RID: 117
		[Serializable]
		public class ButtonClickedEvent : UnityEvent
		{
			// Token: 0x06000B58 RID: 2904 RVA: 0x000060D8 File Offset: 0x000042D8
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonClickedEvent()
			{
				Il2CppClassPointerStore<Button.ButtonClickedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Button>.NativeClassPtr, "ButtonClickedEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button.ButtonClickedEvent>.NativeClassPtr);
				Button.ButtonClickedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button.ButtonClickedEvent>.NativeClassPtr, 100664946);
			}

			// Token: 0x06000B59 RID: 2905 RVA: 0x00032BF0 File Offset: 0x00030DF0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 108007, RefRangeEnd = 108010, XrefRangeStart = 108006, XrefRangeEnd = 108007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonClickedEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button.ButtonClickedEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.ButtonClickedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B5A RID: 2906 RVA: 0x0000610C File Offset: 0x0000430C
			public ButtonClickedEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000898 RID: 2200
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000076 RID: 118
		[ObfuscatedName("UnityEngine.UI.Button+<OnFinishSubmit>d__9")]
		public sealed class _OnFinishSubmit_d__9 : Object
		{
			// Token: 0x06000B5B RID: 2907 RVA: 0x00032C2C File Offset: 0x00030E2C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnFinishSubmit_d__9()
			{
				Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Button>.NativeClassPtr, "<OnFinishSubmit>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr);
				Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, "<>1__state");
				Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, "<>2__current");
				Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, "<>4__this");
				Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__fadeTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, "<fadeTime>5__2");
				Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__elapsedTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, "<elapsedTime>5__3");
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100664947);
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100664948);
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100664949);
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100664950);
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100664951);
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100664952);
			}

			// Token: 0x06000B5C RID: 2908 RVA: 0x00032D34 File Offset: 0x00030F34
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnFinishSubmit_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B5D RID: 2909 RVA: 0x00032D7C File Offset: 0x00030F7C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B5E RID: 2910 RVA: 0x00032DB0 File Offset: 0x00030FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108010, XrefRangeEnd = 108014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003D0 RID: 976
			// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00032DEC File Offset: 0x00030FEC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B60 RID: 2912 RVA: 0x00032E2C File Offset: 0x0003102C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108014, XrefRangeEnd = 108019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003D1 RID: 977
			// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00032E60 File Offset: 0x00031060
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B62 RID: 2914 RVA: 0x00006115 File Offset: 0x00004315
			public _OnFinishSubmit_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003CB RID: 971
			// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00032EA0 File Offset: 0x000310A0
			// (set) Token: 0x06000B64 RID: 2916 RVA: 0x0000611E File Offset: 0x0000431E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003CC RID: 972
			// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00032EC8 File Offset: 0x000310C8
			// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00006139 File Offset: 0x00004339
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CD RID: 973
			// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00032EF8 File Offset: 0x000310F8
			// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00006158 File Offset: 0x00004358
			public unsafe Button __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CE RID: 974
			// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00032F28 File Offset: 0x00031128
			// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00006177 File Offset: 0x00004377
			public unsafe float _fadeTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__fadeTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__fadeTime_5__2)) = value;
				}
			}

			// Token: 0x170003CF RID: 975
			// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00032F50 File Offset: 0x00031150
			// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00006192 File Offset: 0x00004392
			public unsafe float _elapsedTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__elapsedTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__elapsedTime_5__3)) = value;
				}
			}

			// Token: 0x04000899 RID: 2201
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400089A RID: 2202
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400089B RID: 2203
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400089C RID: 2204
			private static readonly IntPtr NativeFieldInfoPtr__fadeTime_5__2;

			// Token: 0x0400089D RID: 2205
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__3;

			// Token: 0x0400089E RID: 2206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400089F RID: 2207
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008A0 RID: 2208
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008A1 RID: 2209
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008A2 RID: 2210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008A3 RID: 2211
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

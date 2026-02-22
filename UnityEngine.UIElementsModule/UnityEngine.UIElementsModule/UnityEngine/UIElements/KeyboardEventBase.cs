using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000071 RID: 113
	public class KeyboardEventBase<T> : EventBase<T> where T : KeyboardEventBase<T>, new()
	{
		// Token: 0x06000682 RID: 1666 RVA: 0x00020E5C File Offset: 0x0001F05C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardEventBase()
		{
			Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "KeyboardEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr);
			KeyboardEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, "<modifiers>k__BackingField");
			KeyboardEventBase<T>.NativeFieldInfoPtr__character_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, "<character>k__BackingField");
			KeyboardEventBase<T>.NativeFieldInfoPtr__keyCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, "<keyCode>k__BackingField");
			KeyboardEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100663876);
			KeyboardEventBase<T>.NativeMethodInfoPtr_set_character_Protected_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100663877);
			KeyboardEventBase<T>.NativeMethodInfoPtr_set_keyCode_Protected_set_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100663878);
			KeyboardEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100663879);
			KeyboardEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100663880);
			KeyboardEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Char_KeyCode_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100663881);
			KeyboardEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100663882);
			KeyboardEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100663883);
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00004ED2 File Offset: 0x000030D2
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		public unsafe EventModifiers modifiers
		{
			get
			{
				return this._modifiers_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00004EDA File Offset: 0x000030DA
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00020FE4 File Offset: 0x0001F1E4
		public unsafe char character
		{
			get
			{
				return this._character_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_set_character_Protected_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00004EE2 File Offset: 0x000030E2
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00021024 File Offset: 0x0001F224
		public unsafe KeyCode keyCode
		{
			get
			{
				return this._keyCode_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_set_keyCode_Protected_set_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00021064 File Offset: 0x0001F264
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 93528, RefRangeEnd = 93542, XrefRangeStart = 93528, XrefRangeEnd = 93542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyboardEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000210A0 File Offset: 0x0001F2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94886, XrefRangeEnd = 94887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000210D4 File Offset: 0x0001F2D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 94906, RefRangeEnd = 94910, XrefRangeStart = 94887, XrefRangeEnd = 94906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Char_KeyCode_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002112C File Offset: 0x0001F32C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94933, RefRangeEnd = 94935, XrefRangeStart = 94910, XrefRangeEnd = 94933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0002116C File Offset: 0x0001F36C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94940, RefRangeEnd = 94942, XrefRangeStart = 94935, XrefRangeEnd = 94940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00004E78 File Offset: 0x00003078
		public KeyboardEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x000211A8 File Offset: 0x0001F3A8
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00004E81 File Offset: 0x00003081
		public unsafe EventModifiers _modifiers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x000211D0 File Offset: 0x0001F3D0
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00004E9C File Offset: 0x0000309C
		public unsafe char _character_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__character_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__character_k__BackingField)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x000211F8 File Offset: 0x0001F3F8
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00004EB7 File Offset: 0x000030B7
		public unsafe KeyCode _keyCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__keyCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__keyCode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00021220 File Offset: 0x0001F420
		public bool shiftKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Shift) > EventModifiers.None;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00021240 File Offset: 0x0001F440
		public bool ctrlKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Control) > EventModifiers.None;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00021260 File Offset: 0x0001F460
		public bool commandKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Command) > EventModifiers.None;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00021280 File Offset: 0x0001F480
		public bool altKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Alt) > EventModifiers.None;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x000212A0 File Offset: 0x0001F4A0
		public bool actionKey
		{
			get
			{
				bool flag = Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer;
				bool flag2;
				if (flag)
				{
					flag2 = this.commandKey;
				}
				else
				{
					flag2 = this.ctrlKey;
				}
				return flag2;
			}
		}

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr__character_k__BackingField;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr__keyCode_k__BackingField;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_set_character_Protected_set_Void_Char_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_set_keyCode_Protected_set_Void_KeyCode_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_Char_KeyCode_EventModifiers_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

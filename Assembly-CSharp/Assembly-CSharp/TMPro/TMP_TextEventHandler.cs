using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace TMPro
{
	// Token: 0x020000FC RID: 252
	public class TMP_TextEventHandler : MonoBehaviour
	{
		// Token: 0x06001E1B RID: 7707 RVA: 0x000766F8 File Offset: 0x000748F8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextEventHandler()
		{
			Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro", "TMP_TextEventHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr);
			TMP_TextEventHandler.NativeFieldInfoPtr_m_OnCharacterSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_OnCharacterSelection");
			TMP_TextEventHandler.NativeFieldInfoPtr_m_OnWordSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_OnWordSelection");
			TMP_TextEventHandler.NativeFieldInfoPtr_m_OnLineSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_OnLineSelection");
			TMP_TextEventHandler.NativeFieldInfoPtr_m_OnLinkSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_OnLinkSelection");
			TMP_TextEventHandler.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_TextComponent");
			TMP_TextEventHandler.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_Camera");
			TMP_TextEventHandler.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_Canvas");
			TMP_TextEventHandler.NativeFieldInfoPtr_m_selectedLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_selectedLink");
			TMP_TextEventHandler.NativeFieldInfoPtr_m_lastCharIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_lastCharIndex");
			TMP_TextEventHandler.NativeFieldInfoPtr_m_lastWordIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_lastWordIndex");
			TMP_TextEventHandler.NativeFieldInfoPtr_m_lastLineIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "m_lastLineIndex");
			TMP_TextEventHandler.NativeMethodInfoPtr_get_onCharacterSelection_Public_get_CharacterSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665790);
			TMP_TextEventHandler.NativeMethodInfoPtr_set_onCharacterSelection_Public_set_Void_CharacterSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665791);
			TMP_TextEventHandler.NativeMethodInfoPtr_get_onWordSelection_Public_get_WordSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665792);
			TMP_TextEventHandler.NativeMethodInfoPtr_set_onWordSelection_Public_set_Void_WordSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665793);
			TMP_TextEventHandler.NativeMethodInfoPtr_get_onLineSelection_Public_get_LineSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665794);
			TMP_TextEventHandler.NativeMethodInfoPtr_set_onLineSelection_Public_set_Void_LineSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665795);
			TMP_TextEventHandler.NativeMethodInfoPtr_get_onLinkSelection_Public_get_LinkSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665796);
			TMP_TextEventHandler.NativeMethodInfoPtr_set_onLinkSelection_Public_set_Void_LinkSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665797);
			TMP_TextEventHandler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665798);
			TMP_TextEventHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665799);
			TMP_TextEventHandler.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665800);
			TMP_TextEventHandler.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665801);
			TMP_TextEventHandler.NativeMethodInfoPtr_SendOnCharacterSelection_Private_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665802);
			TMP_TextEventHandler.NativeMethodInfoPtr_SendOnWordSelection_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665803);
			TMP_TextEventHandler.NativeMethodInfoPtr_SendOnLineSelection_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665804);
			TMP_TextEventHandler.NativeMethodInfoPtr_SendOnLinkSelection_Private_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665805);
			TMP_TextEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, 100665806);
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00076958 File Offset: 0x00074B58
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x00076998 File Offset: 0x00074B98
		public unsafe TMP_TextEventHandler.CharacterSelectionEvent onCharacterSelection
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_get_onCharacterSelection_Public_get_CharacterSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextEventHandler.CharacterSelectionEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_set_onCharacterSelection_Public_set_Void_CharacterSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000769DC File Offset: 0x00074BDC
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x00076A1C File Offset: 0x00074C1C
		public unsafe TMP_TextEventHandler.WordSelectionEvent onWordSelection
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_get_onWordSelection_Public_get_WordSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextEventHandler.WordSelectionEvent>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_set_onWordSelection_Public_set_Void_WordSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x00076A60 File Offset: 0x00074C60
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x00076AA0 File Offset: 0x00074CA0
		public unsafe TMP_TextEventHandler.LineSelectionEvent onLineSelection
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_get_onLineSelection_Public_get_LineSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextEventHandler.LineSelectionEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_set_onLineSelection_Public_set_Void_LineSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x00076AE4 File Offset: 0x00074CE4
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x00076B24 File Offset: 0x00074D24
		public unsafe TMP_TextEventHandler.LinkSelectionEvent onLinkSelection
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_get_onLinkSelection_Public_get_LinkSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextEventHandler.LinkSelectionEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_set_onLinkSelection_Public_set_Void_LinkSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00076B68 File Offset: 0x00074D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255551, XrefRangeEnd = 255566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00076B9C File Offset: 0x00074D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255566, XrefRangeEnd = 255607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00076BD0 File Offset: 0x00074DD0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00076C14 File Offset: 0x00074E14
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00076C58 File Offset: 0x00074E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255607, XrefRangeEnd = 255610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnCharacterSelection(char character, int characterIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_SendOnCharacterSelection_Private_Void_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00076CA4 File Offset: 0x00074EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255610, XrefRangeEnd = 255613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnWordSelection(string word, int charIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(word);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_SendOnWordSelection_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00076D04 File Offset: 0x00074F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255613, XrefRangeEnd = 255616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnLineSelection(string line, int charIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_SendOnLineSelection_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00076D64 File Offset: 0x00074F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255616, XrefRangeEnd = 255619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(linkID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkText);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linkIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr_SendOnLinkSelection_Private_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00076DC8 File Offset: 0x00074FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255619, XrefRangeEnd = 255636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextEventHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00012C41 File Offset: 0x00010E41
		public TMP_TextEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00076E04 File Offset: 0x00075004
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x00012C4A File Offset: 0x00010E4A
		public unsafe TMP_TextEventHandler.CharacterSelectionEvent m_OnCharacterSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_OnCharacterSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextEventHandler.CharacterSelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_OnCharacterSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00076E34 File Offset: 0x00075034
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x00012C69 File Offset: 0x00010E69
		public unsafe TMP_TextEventHandler.WordSelectionEvent m_OnWordSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_OnWordSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextEventHandler.WordSelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_OnWordSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00076E64 File Offset: 0x00075064
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x00012C88 File Offset: 0x00010E88
		public unsafe TMP_TextEventHandler.LineSelectionEvent m_OnLineSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_OnLineSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextEventHandler.LineSelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_OnLineSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00076E94 File Offset: 0x00075094
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x00012CA7 File Offset: 0x00010EA7
		public unsafe TMP_TextEventHandler.LinkSelectionEvent m_OnLinkSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_OnLinkSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextEventHandler.LinkSelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_OnLinkSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00076EC4 File Offset: 0x000750C4
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x00012CC6 File Offset: 0x00010EC6
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00076EF4 File Offset: 0x000750F4
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x00012CE5 File Offset: 0x00010EE5
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x00076F24 File Offset: 0x00075124
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x00012D04 File Offset: 0x00010F04
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00076F54 File Offset: 0x00075154
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x00012D23 File Offset: 0x00010F23
		public unsafe int m_selectedLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_selectedLink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_selectedLink)) = value;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00076F7C File Offset: 0x0007517C
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x00012D3E File Offset: 0x00010F3E
		public unsafe int m_lastCharIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_lastCharIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_lastCharIndex)) = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00076FA4 File Offset: 0x000751A4
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x00012D59 File Offset: 0x00010F59
		public unsafe int m_lastWordIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_lastWordIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_lastWordIndex)) = value;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x00076FCC File Offset: 0x000751CC
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x00012D74 File Offset: 0x00010F74
		public unsafe int m_lastLineIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_lastLineIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventHandler.NativeFieldInfoPtr_m_lastLineIndex)) = value;
			}
		}

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeFieldInfoPtr_m_OnCharacterSelection;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeFieldInfoPtr_m_OnWordSelection;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeFieldInfoPtr_m_OnLineSelection;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeFieldInfoPtr_m_OnLinkSelection;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeFieldInfoPtr_m_selectedLink;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeFieldInfoPtr_m_lastCharIndex;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeFieldInfoPtr_m_lastWordIndex;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeFieldInfoPtr_m_lastLineIndex;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr_get_onCharacterSelection_Public_get_CharacterSelectionEvent_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr_set_onCharacterSelection_Public_set_Void_CharacterSelectionEvent_0;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_get_onWordSelection_Public_get_WordSelectionEvent_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_set_onWordSelection_Public_set_Void_WordSelectionEvent_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_get_onLineSelection_Public_get_LineSelectionEvent_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_set_onLineSelection_Public_set_Void_LineSelectionEvent_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_get_onLinkSelection_Public_get_LinkSelectionEvent_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_set_onLinkSelection_Public_set_Void_LinkSelectionEvent_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_SendOnCharacterSelection_Private_Void_Char_Int32_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_SendOnWordSelection_Private_Void_String_Int32_Int32_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_SendOnLineSelection_Private_Void_String_Int32_Int32_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_SendOnLinkSelection_Private_Void_String_String_Int32_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200021E RID: 542
		[Serializable]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			// Token: 0x06002A53 RID: 10835 RVA: 0x00019FA6 File Offset: 0x000181A6
			// Note: this type is marked as 'beforefieldinit'.
			static CharacterSelectionEvent()
			{
				Il2CppClassPointerStore<TMP_TextEventHandler.CharacterSelectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "CharacterSelectionEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextEventHandler.CharacterSelectionEvent>.NativeClassPtr);
				TMP_TextEventHandler.CharacterSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler.CharacterSelectionEvent>.NativeClassPtr, 100666631);
			}

			// Token: 0x06002A54 RID: 10836 RVA: 0x00097DC4 File Offset: 0x00095FC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 255538, RefRangeEnd = 255539, XrefRangeStart = 255535, XrefRangeEnd = 255538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CharacterSelectionEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextEventHandler.CharacterSelectionEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.CharacterSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A55 RID: 10837 RVA: 0x00019FDA File Offset: 0x000181DA
			public CharacterSelectionEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001CF1 RID: 7409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200021F RID: 543
		[Serializable]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			// Token: 0x06002A56 RID: 10838 RVA: 0x00019FE3 File Offset: 0x000181E3
			// Note: this type is marked as 'beforefieldinit'.
			static WordSelectionEvent()
			{
				Il2CppClassPointerStore<TMP_TextEventHandler.WordSelectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "WordSelectionEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextEventHandler.WordSelectionEvent>.NativeClassPtr);
				TMP_TextEventHandler.WordSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler.WordSelectionEvent>.NativeClassPtr, 100666632);
			}

			// Token: 0x06002A57 RID: 10839 RVA: 0x00097E00 File Offset: 0x00096000
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 255542, RefRangeEnd = 255543, XrefRangeStart = 255539, XrefRangeEnd = 255542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WordSelectionEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextEventHandler.WordSelectionEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.WordSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A58 RID: 10840 RVA: 0x0001A017 File Offset: 0x00018217
			public WordSelectionEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001CF2 RID: 7410
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000220 RID: 544
		[Serializable]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			// Token: 0x06002A59 RID: 10841 RVA: 0x0001A020 File Offset: 0x00018220
			// Note: this type is marked as 'beforefieldinit'.
			static LineSelectionEvent()
			{
				Il2CppClassPointerStore<TMP_TextEventHandler.LineSelectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "LineSelectionEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextEventHandler.LineSelectionEvent>.NativeClassPtr);
				TMP_TextEventHandler.LineSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler.LineSelectionEvent>.NativeClassPtr, 100666633);
			}

			// Token: 0x06002A5A RID: 10842 RVA: 0x00097E3C File Offset: 0x0009603C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 255546, RefRangeEnd = 255547, XrefRangeStart = 255543, XrefRangeEnd = 255546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LineSelectionEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextEventHandler.LineSelectionEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.LineSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A5B RID: 10843 RVA: 0x0001A054 File Offset: 0x00018254
			public LineSelectionEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001CF3 RID: 7411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000221 RID: 545
		[Serializable]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			// Token: 0x06002A5C RID: 10844 RVA: 0x0001A05D File Offset: 0x0001825D
			// Note: this type is marked as 'beforefieldinit'.
			static LinkSelectionEvent()
			{
				Il2CppClassPointerStore<TMP_TextEventHandler.LinkSelectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_TextEventHandler>.NativeClassPtr, "LinkSelectionEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextEventHandler.LinkSelectionEvent>.NativeClassPtr);
				TMP_TextEventHandler.LinkSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventHandler.LinkSelectionEvent>.NativeClassPtr, 100666634);
			}

			// Token: 0x06002A5D RID: 10845 RVA: 0x00097E78 File Offset: 0x00096078
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 255550, RefRangeEnd = 255551, XrefRangeStart = 255547, XrefRangeEnd = 255550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LinkSelectionEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextEventHandler.LinkSelectionEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventHandler.LinkSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A5E RID: 10846 RVA: 0x0001A091 File Offset: 0x00018291
			public LinkSelectionEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001CF4 RID: 7412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

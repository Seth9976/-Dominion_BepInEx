using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace SA.Foundation.EditorStylesCollection
{
	// Token: 0x02000354 RID: 852
	public class SA_ESC_PropertyDrawerExample : MonoBehaviour
	{
		// Token: 0x06003360 RID: 13152 RVA: 0x000D5F10 File Offset: 0x000D4110
		// Note: this type is marked as 'beforefieldinit'.
		static SA_ESC_PropertyDrawerExample()
		{
			Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.EditorStylesCollection", "SA_ESC_PropertyDrawerExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr);
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_multilineString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "m_multilineString");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_textAreaString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "m_textAreaString");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_intRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "m_intRange");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_floatRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "m_floatRange");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_hoverMouseToSeeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "m_hoverMouseToSeeTooltip");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_simpleSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "m_simpleSlider");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_MinMaxSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "m_MinMaxSlider");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_myHelpBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "myHelpBox");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_myString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "myString");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_indentLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "indentLevel");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_indentLevel1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "indentLevel1");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_indentLevel2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "indentLevel2");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_showBelowSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "showBelowSettings");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "range");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_isExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "isExists");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "curve");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_enableBelowSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "enableBelowSettings");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_firstSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "firstSettings");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_secondSettigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "secondSettigs");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_myLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "myLabel");
			SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_favoriteLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, "favoriteLabel");
			SA_ESC_PropertyDrawerExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr, 100669881);
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000D60F8 File Offset: 0x000D42F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223744, XrefRangeEnd = 223753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_ESC_PropertyDrawerExample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ESC_PropertyDrawerExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ESC_PropertyDrawerExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x00013F5A File Offset: 0x0001215A
		public SA_ESC_PropertyDrawerExample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06003363 RID: 13155 RVA: 0x000D6134 File Offset: 0x000D4334
		// (set) Token: 0x06003364 RID: 13156 RVA: 0x00013F63 File Offset: 0x00012163
		public unsafe string m_multilineString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_multilineString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_multilineString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06003365 RID: 13157 RVA: 0x000D615C File Offset: 0x000D435C
		// (set) Token: 0x06003366 RID: 13158 RVA: 0x00013F82 File Offset: 0x00012182
		public unsafe string m_textAreaString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_textAreaString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_textAreaString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x000D6184 File Offset: 0x000D4384
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x00013FA1 File Offset: 0x000121A1
		public unsafe int m_intRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_intRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_intRange)) = value;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06003369 RID: 13161 RVA: 0x000D61AC File Offset: 0x000D43AC
		// (set) Token: 0x0600336A RID: 13162 RVA: 0x00013FBC File Offset: 0x000121BC
		public unsafe float m_floatRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_floatRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_floatRange)) = value;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600336B RID: 13163 RVA: 0x000D61D4 File Offset: 0x000D43D4
		// (set) Token: 0x0600336C RID: 13164 RVA: 0x00013FD7 File Offset: 0x000121D7
		public unsafe float m_hoverMouseToSeeTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_hoverMouseToSeeTooltip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_hoverMouseToSeeTooltip)) = value;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600336D RID: 13165 RVA: 0x000D61FC File Offset: 0x000D43FC
		// (set) Token: 0x0600336E RID: 13166 RVA: 0x00013FF2 File Offset: 0x000121F2
		public unsafe float m_simpleSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_simpleSlider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_simpleSlider)) = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600336F RID: 13167 RVA: 0x000D6224 File Offset: 0x000D4424
		// (set) Token: 0x06003370 RID: 13168 RVA: 0x0001400D File Offset: 0x0001220D
		public unsafe Vector2 m_MinMaxSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_MinMaxSlider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_m_MinMaxSlider)) = value;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06003371 RID: 13169 RVA: 0x000D624C File Offset: 0x000D444C
		// (set) Token: 0x06003372 RID: 13170 RVA: 0x00014028 File Offset: 0x00012228
		public unsafe string myHelpBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_myHelpBox);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_myHelpBox), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06003373 RID: 13171 RVA: 0x000D6274 File Offset: 0x000D4474
		// (set) Token: 0x06003374 RID: 13172 RVA: 0x00014047 File Offset: 0x00012247
		public unsafe string myString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_myString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_myString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06003375 RID: 13173 RVA: 0x000D629C File Offset: 0x000D449C
		// (set) Token: 0x06003376 RID: 13174 RVA: 0x00014066 File Offset: 0x00012266
		public unsafe string indentLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_indentLevel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_indentLevel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06003377 RID: 13175 RVA: 0x000D62C4 File Offset: 0x000D44C4
		// (set) Token: 0x06003378 RID: 13176 RVA: 0x00014085 File Offset: 0x00012285
		public unsafe string indentLevel1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_indentLevel1);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_indentLevel1), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06003379 RID: 13177 RVA: 0x000D62EC File Offset: 0x000D44EC
		// (set) Token: 0x0600337A RID: 13178 RVA: 0x000140A4 File Offset: 0x000122A4
		public unsafe string indentLevel2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_indentLevel2);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_indentLevel2), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600337B RID: 13179 RVA: 0x000D6314 File Offset: 0x000D4514
		// (set) Token: 0x0600337C RID: 13180 RVA: 0x000140C3 File Offset: 0x000122C3
		public unsafe bool showBelowSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_showBelowSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_showBelowSettings)) = value;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x0600337D RID: 13181 RVA: 0x000D633C File Offset: 0x000D453C
		// (set) Token: 0x0600337E RID: 13182 RVA: 0x000140DE File Offset: 0x000122DE
		public unsafe float range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x0600337F RID: 13183 RVA: 0x000D6364 File Offset: 0x000D4564
		// (set) Token: 0x06003380 RID: 13184 RVA: 0x000140F9 File Offset: 0x000122F9
		public unsafe bool isExists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_isExists);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_isExists)) = value;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06003381 RID: 13185 RVA: 0x000D638C File Offset: 0x000D458C
		// (set) Token: 0x06003382 RID: 13186 RVA: 0x00014114 File Offset: 0x00012314
		public unsafe AnimationCurve curve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_curve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06003383 RID: 13187 RVA: 0x000D63BC File Offset: 0x000D45BC
		// (set) Token: 0x06003384 RID: 13188 RVA: 0x00014133 File Offset: 0x00012333
		public unsafe bool enableBelowSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_enableBelowSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_enableBelowSettings)) = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06003385 RID: 13189 RVA: 0x000D63E4 File Offset: 0x000D45E4
		// (set) Token: 0x06003386 RID: 13190 RVA: 0x0001414E File Offset: 0x0001234E
		public unsafe bool firstSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_firstSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_firstSettings)) = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06003387 RID: 13191 RVA: 0x000D640C File Offset: 0x000D460C
		// (set) Token: 0x06003388 RID: 13192 RVA: 0x00014169 File Offset: 0x00012369
		public unsafe float secondSettigs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_secondSettigs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_secondSettigs)) = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06003389 RID: 13193 RVA: 0x000D6434 File Offset: 0x000D4634
		// (set) Token: 0x0600338A RID: 13194 RVA: 0x00014184 File Offset: 0x00012384
		public unsafe string myLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_myLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_myLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x0600338B RID: 13195 RVA: 0x000D645C File Offset: 0x000D465C
		// (set) Token: 0x0600338C RID: 13196 RVA: 0x000141A3 File Offset: 0x000123A3
		public unsafe string favoriteLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_favoriteLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ESC_PropertyDrawerExample.NativeFieldInfoPtr_favoriteLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002FCE RID: 12238
		private static readonly IntPtr NativeFieldInfoPtr_m_multilineString;

		// Token: 0x04002FCF RID: 12239
		private static readonly IntPtr NativeFieldInfoPtr_m_textAreaString;

		// Token: 0x04002FD0 RID: 12240
		private static readonly IntPtr NativeFieldInfoPtr_m_intRange;

		// Token: 0x04002FD1 RID: 12241
		private static readonly IntPtr NativeFieldInfoPtr_m_floatRange;

		// Token: 0x04002FD2 RID: 12242
		private static readonly IntPtr NativeFieldInfoPtr_m_hoverMouseToSeeTooltip;

		// Token: 0x04002FD3 RID: 12243
		private static readonly IntPtr NativeFieldInfoPtr_m_simpleSlider;

		// Token: 0x04002FD4 RID: 12244
		private static readonly IntPtr NativeFieldInfoPtr_m_MinMaxSlider;

		// Token: 0x04002FD5 RID: 12245
		private static readonly IntPtr NativeFieldInfoPtr_myHelpBox;

		// Token: 0x04002FD6 RID: 12246
		private static readonly IntPtr NativeFieldInfoPtr_myString;

		// Token: 0x04002FD7 RID: 12247
		private static readonly IntPtr NativeFieldInfoPtr_indentLevel;

		// Token: 0x04002FD8 RID: 12248
		private static readonly IntPtr NativeFieldInfoPtr_indentLevel1;

		// Token: 0x04002FD9 RID: 12249
		private static readonly IntPtr NativeFieldInfoPtr_indentLevel2;

		// Token: 0x04002FDA RID: 12250
		private static readonly IntPtr NativeFieldInfoPtr_showBelowSettings;

		// Token: 0x04002FDB RID: 12251
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04002FDC RID: 12252
		private static readonly IntPtr NativeFieldInfoPtr_isExists;

		// Token: 0x04002FDD RID: 12253
		private static readonly IntPtr NativeFieldInfoPtr_curve;

		// Token: 0x04002FDE RID: 12254
		private static readonly IntPtr NativeFieldInfoPtr_enableBelowSettings;

		// Token: 0x04002FDF RID: 12255
		private static readonly IntPtr NativeFieldInfoPtr_firstSettings;

		// Token: 0x04002FE0 RID: 12256
		private static readonly IntPtr NativeFieldInfoPtr_secondSettigs;

		// Token: 0x04002FE1 RID: 12257
		private static readonly IntPtr NativeFieldInfoPtr_myLabel;

		// Token: 0x04002FE2 RID: 12258
		private static readonly IntPtr NativeFieldInfoPtr_favoriteLabel;

		// Token: 0x04002FE3 RID: 12259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

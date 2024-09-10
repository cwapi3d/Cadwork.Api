// Copyright (C) Cadwork. All rights reserved.

using Cadwork.Api.Interfaces.Helpers;

namespace Cadwork.Api.Interfaces.Controllers;

using ElementId = ulong;
using EndTypeId = ulong;

/// <summary>
/// 
/// </summary>
public interface IEndTypeController
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <param name="endTypeId"></param>
  /// <param name="folderName"></param>
  /// <returns></returns>
  EndTypeId CreateEndType(string name, EndTypeId endTypeId, string folderName);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  EndTypeId GetEndTypeId(string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  EndTypeId GetEndTypeIdAtEnd(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  EndTypeId GetEndTypeIdAtStart(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="facetIndex"></param>
  /// <returns></returns>
  EndTypeId GetEndTypeIdOnFacet(ElementId elementId, uint facetIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  EndTypeId StartEndTypeDialog();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<EndTypeId> GetExistingDovetailDadoIds();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<EndTypeId> GetExistingDovetailIds();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<EndTypeId> GetExistingJapaneseTenonIds();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<EndTypeId> GetExistingLengtheningIds();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  ICollection<EndTypeId> GetExistingTenonIds();

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  IError GetLastError();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetEndTypeName(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetEndTypeNameAtEnd(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <returns></returns>
  string GetEndTypeNameAtStart(ElementId elementId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="facetIndex"></param>
  /// <returns></returns>
  string GetEndTypeNameOnFacet(ElementId elementId, uint facetIndex);

  /// <summary>
  /// 
  /// </summary>
  void ClearErrors();

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="endTypeId"></param>
  void SetEndTypeIdAtEnd(ElementId elementId, EndTypeId endTypeId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="endTypeId"></param>
  void SetEndTypeIdAtStart(ElementId elementId, EndTypeId endTypeId);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="endTypeId"></param>
  /// <param name="facetIndex"></param>
  void SetEndTypeIdOnFacet(ElementId elementId, EndTypeId endTypeId, uint facetIndex);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="name"></param>
  void SetEndTypeNameAtEnd(ElementId elementId, string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="name"></param>
  void SetEndTypeNameAtStart(ElementId elementId, string name);

  /// <summary>
  /// 
  /// </summary>
  /// <param name="elementId"></param>
  /// <param name="name"></param>
  /// <param name="facetIndex"></param>
  void SetEndTypeNameOnFacet(ElementId elementId, string name, uint facetIndex);
};
